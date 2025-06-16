using C__project_1.Controler;
using C__project_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C__project_1.viwes
{
    public partial class Student : Form
    {
        private TextBox Address;

        public object Id { get; private set; }
        public object UpdateStudentId { get; private set; }
        public object Age { get; internal set; }

        public Student()
        {
            InitializeComponent();
            StudentController controller = new StudentController();
            student_grw.DataSource = controller.GetAllStudents();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UpdateStudentId == null)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            StudentController controller = new StudentController();
            controller.DeleteStudent(Convert.ToInt32(UpdateStudentId));

            MessageBox.Show("Student deleted successfully.");

            // Clear form
            txt_studentname.Text = "";
            txt_studentAddress.Text = "";
            txt_studentNIC.Text = "";

            // Refresh grid
            student_grw.DataSource = controller.GetAllStudents();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_studentname.Text) ||
        string.IsNullOrWhiteSpace(txt_studentAddress.Text) ||
        string.IsNullOrWhiteSpace(txt_studentNIC.Text))
            {
                MessageBox.Show("Please enter all details.");
                return;
            }

            var student = new Models.Student
            {
                Name = txt_studentname.Text,
                Address = txt_studentAddress.Text,
                NIC = txt_studentNIC.Text
            };

            StudentController controller = new StudentController();
            controller.AddStudent(student);

            MessageBox.Show("Student added successfully.");

            // Clear form
            txt_studentname.Text = "";
            txt_studentAddress.Text = "";
            txt_studentNIC.Text = "";

            // Refresh grid
            student_grw.DataSource = controller.GetAllStudents();
        }








        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var student = new Models.Student
            {
                Name = txt_studentname.Text,
                Address = txt_studentAddress.Text,
                NIC = txt_studentNIC.Text,
                Id = Convert.ToInt32(UpdateStudentId)
            };

            StudentController controller = new StudentController();
            controller.UpdateStudent(student);
            MessageBox.Show("Student updated successfully.");

            txt_studentname.Text = "";
            txt_studentAddress.Text = "";
            txt_studentNIC.Text = "";

            student_grw.DataSource = controller.GetAllStudents();
        }

        private void student_grw_SelectionChanged(object sender, EventArgs e)
        {

            {
                if (student_grw.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = student_grw.SelectedRows[0];

                    txt_studentname.Text = selectedRow.Cells["Name"].Value?.ToString() ?? "";
                    txt_studentAddress.Text = selectedRow.Cells["Address"].Value?.ToString() ?? "";
                    txt_studentNIC.Text = selectedRow.Cells["NIC"].Value?.ToString() ?? "";

                    // Set the UpdateStudentId for update/delete operations
                    if (int.TryParse(selectedRow.Cells["Id"].Value?.ToString(), out int id))
                    {
                        UpdateStudentId = id;
                    }
                    else
                    {
                        UpdateStudentId = null;
                    }
                }
            }
        }
    }
}



        

    

 


