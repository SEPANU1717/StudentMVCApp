using StudentMVCApp.Model;

namespace StudentMVCApp.Controller
{
    public class StudentController
    {
        private readonly StudentRepository _repository;

        public StudentController(StudentRepository studentRepository) { _repository = studentRepository; }

        public string AddStudent(Student student)
        {
            if (student is null)
                return "Student cannot be null.";
            try
            {
                if (string.IsNullOrWhiteSpace(student.FullName))
                    return "Full Name is required.";

                if (student.Age <= 0)
                    return "Age must be greater than zero.";

                _repository.AddStudent(student);
                return "Student added successfully.";
            }
            catch (Exception ex) { return $"Error adding student: {ex.Message}"; }
        }

        public List<Student> GetAllStudents()
        {
            try { return _repository.GetAllStudents(); }
            catch { return new List<Student>(); }
        }
        public string EditStudents(Student? students)
        {
            if(students is null) return "student cannot be null.";
            if(string.IsNullOrWhiteSpace(students.FullName)) return "Full Name is required.";
            if(students.Age <=0 || students.Age > 80) return "Age must be between 1 and 80.";

            return _repository.EditStudent(students) ? "Student updated successfully." : "Student not found.";
        }
        public List<Student> SearchByName(string name) => _repository.SearchByName(name);
        public string DeleteStudents(int id) => _repository.DeleteStudents(id) ? "Student deleted successfully." : "Student not found.";

    }
}
