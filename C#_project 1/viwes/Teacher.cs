using C__project_1.Controler;
using C__project_1.Controllers;
using C__project_1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__project_1.viwes
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            TeacherController controller = new TeacherController();
            dgv_Teacher.DataSource = controller.GetAllTeachers();
        }

        public object UpdateTeacherId { get; private set; }

        private void btn_Add_tec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tec_name.Text) ||
    string.IsNullOrWhiteSpace(txt_tec_Address.Text) ||
    string.IsNullOrWhiteSpace(txt_tec_NIC.Text))
            {
                MessageBox.Show("Please enter all details.");
                return;
            }

            var teacher = new Models.Teacher
            {
                Name = txt_tec_name.Text,
                Address = txt_tec_Address.Text,
                NIC = txt_tec_NIC.Text
            };

            TeacherController controller = new TeacherController();
            controller.AddTeacher(teacher);

            MessageBox.Show("Teacher added successfully.");

            // Clear form
            txt_tec_name.Text = "";
            txt_tec_Address.Text = "";
            txt_tec_NIC.Text = "";

            // Refresh grid
            dgv_Teacher.DataSource = controller.GetAllTeachers();
        }

        private void btn_Update_tec_Click(object sender, EventArgs e)
        {
            var teacher = new Models.Teacher
            {
                Name = txt_tec_name.Text,
                Address = txt_tec_Address.Text,
                NIC = txt_tec_NIC.Text,
                Id = Convert.ToInt32(UpdateTeacherId)
            };

            TeacherController controller = new TeacherController();
            controller.UpdateTeacher(teacher);
            MessageBox.Show("Teacher updated successfully.");

            txt_tec_name.Text = "";
            txt_tec_Address.Text = "";
            txt_tec_NIC.Text = "";

            dgv_Teacher.DataSource = controller.GetAllTeachers();
        }

        private void student_grw_SelectionChanged(object sender, EventArgs e)
        {

            {
                if (dgv_Teacher.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgv_Teacher.SelectedRows[0];

                    txt_tec_name.Text = selectedRow.Cells["Name"].Value?.ToString() ?? "";
                    txt_tec_Address.Text = selectedRow.Cells["Address"].Value?.ToString() ?? "";
                    txt_tec_NIC.Text = selectedRow.Cells["NIC"].Value?.ToString() ?? "";

                    // Set the UpdateStudentId for update/delete operations
                    if (int.TryParse(selectedRow.Cells["Id"].Value?.ToString(), out int id))
                    {
                        UpdateTeacherId = id;
                    }
                    else
                    {
                        UpdateTeacherId = null;
                    }
                }
            }
        }

        private void btn_delete_tec_Click(object sender, EventArgs e)
        {
            if (UpdateTeacherId == null)
            {
                MessageBox.Show("Please select a teacher to delete.");
                return;
            }

            TeacherController controller = new TeacherController();
            controller.DeleteTeacher(Convert.ToInt32(UpdateTeacherId));

            MessageBox.Show("Teacher deleted successfully.");

            // Clear form
            txt_tec_name.Text = "";
            txt_tec_Address.Text = "";
            txt_tec_NIC.Text = "";

            // Refresh grid
            dgv_Teacher.DataSource = controller.GetAllTeachers();
        }

        private void dgv_Teacher_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Teacher.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_Teacher.SelectedRows[0];

                txt_tec_name.Text = selectedRow.Cells["Name"].Value?.ToString() ?? "";
                txt_tec_Address.Text = selectedRow.Cells["Address"].Value?.ToString() ?? "";
                txt_tec_NIC.Text = selectedRow.Cells["NIC"].Value?.ToString() ?? "";

                // Set the UpdateStudentId for update/delete operations
                if (int.TryParse(selectedRow.Cells["Id"].Value?.ToString(), out int id))
                {
                    UpdateTeacherId = id;
                }
                else
                {
                    UpdateTeacherId = null;
                }
            }
        }

        private void btn_back_tec_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
    

    
    

