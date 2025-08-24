using MaterialSkin;
using StudentMVCApp.Controller;
using StudentMVCApp.Model;

namespace StudentMVCApp.View.Forms
{
    public partial class Form1 : Form
    {
        private readonly StudentController _studentController;

        public Form1()
        {
            InitializeComponent();
            _studentController = new StudentController(new StudentRepository());
            AssociateAndRaise();
        }

        private void AssociateAndRaise()
        {
            #region AddStudent
            btnAdd.Click += delegate
            {
                var student = new Student
                {
                    Id = DateTime.Now.Millisecond,
                    FullName = txtName.Content,
                    Age = int.TryParse(txtAge.Content, out int age) ? age : 0
                };
                string result = _studentController.AddStudent(student);
                MessageBox.Show(result);

                txtName.Content = string.Empty;
                txtAge.Content = string.Empty;
            };
            #endregion

            #region ViewAllStudents
            btnViewAll.Click += delegate
            {
                lsStudents.Items.Clear();
                var students = _studentController.GetAllStudents();
                foreach (var student in students)
                {
                    lsStudents.Items.Add(new MaterialListBoxItem
                    {
                        Text = $"{student.Id} - {student.FullName} (Age: {student.Age})"
                    });
                }
            };
            #endregion

            #region SearchStudent
            btnSearch.Click += delegate
            {
                lsStudents.Items.Clear();
                var students = _studentController.SearchByName(txtSearch.Content);
                foreach (var student in students)
                {
                    lsStudents.Items.Add(new MaterialListBoxItem
                    {
                        Text = $"{student.Id} - {student.FullName} (Age: {student.Age})"
                    });
                }
            };
            #endregion

            #region EditStudent
            btnEdit.Click += delegate
            {
                if (lsStudents.SelectedItem is null)
                {
                    MessageBox.Show("Select a student to edit.");
                    return;
                }

                var selectedItem = lsStudents.SelectedItem as MaterialListBoxItem;
                if (selectedItem is null)
                {
                    MessageBox.Show("Invalid selection.");
                    return;
                }

                var idText = selectedItem.Text
                    .Split('-')
                    .Select(s => s.Trim())
                    .First();

                if (!int.TryParse(idText, out int id))
                {
                    MessageBox.Show("Invalid student ID.");
                    return;
                }

                if (btnEdit.Text == "Edit")
                {
                    var student = _studentController.GetAllStudents()
                        .FirstOrDefault(s => s.Id == id);

                    if (student is not null)
                    {
                        txtName.Content = student.FullName;
                        txtAge.Content = student.Age.ToString();
                    }

                    btnEdit.Text = "Update";
                }
                else 
                {
                    var updated = new Student
                    {
                        Id = id,
                        FullName = txtName.Content,
                        Age = int.TryParse(txtAge.Content, out int age) ? age : 0
                    };

                    MessageBox.Show(_studentController.EditStudents(updated));

                    btnViewAll.PerformClick();
                    txtName.Content = string.Empty;
                    txtAge.Content = string.Empty;
                    btnEdit.Text = "Edit";
                }
            };
            #endregion

            #region DeleteStudent
            btnDelete.Click += delegate
            {
                if (lsStudents.SelectedItem is null)
                {
                    MessageBox.Show("Please select a student to delete");
                    return;
                }
                var selected = lsStudents.SelectedItem.Text;
                var idPart = selected
                    .Split('-')          
                    .Select(s => s.Trim()) 
                    .FirstOrDefault();
                if (!int.TryParse(idPart, out int id))
                {
                    MessageBox.Show("Invalid selection.");
                    return;
                }
                string result = _studentController.DeleteStudents(id);
                MessageBox.Show(result);
                btnViewAll.PerformClick();
            };
        }
            #endregion
    }
}
