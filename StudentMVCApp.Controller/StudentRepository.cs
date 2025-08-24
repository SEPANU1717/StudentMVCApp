using StudentMVCApp.Model;

namespace StudentMVCApp.Controller
{
    public class StudentRepository
    {
        private readonly List<Student> _students = new List<Student>();
        public void AddStudent(Student student) { _students.Add(student); }
        public List<Student> GetAllStudents() { return _students; }


        public List<Student> SearchByName(string name)
        {
            if (string.IsNullOrEmpty(name)) return [.. _students]; //simplified version ng collection expression

            return _students.
                Where(s => s.FullName.
                Contains(name, StringComparison.OrdinalIgnoreCase)).
                ToList();
        }

        public bool EditStudent(Student students)
        {
            var student = _students.
                FirstOrDefault(s => s.Id == students.Id);
            if (student is null) return false;

            student.FullName = students.FullName;
            student.Age = students.Age;
            return true;
        }

        public bool DeleteStudents(int id)
        {
            var student = _students.
                FirstOrDefault(s => s.Id == id);
            if (student is null) return false;

            _students.Remove(student);
            return true;
        }
    }
}
