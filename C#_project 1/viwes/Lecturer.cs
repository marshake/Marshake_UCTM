using C__project_1.Controler;
using C__project_1.Controllers;
using C__project_1.Models;
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
    public partial class Lecturer : Form
    {
        public object UpdateLecturerId { get; private set; }

        public Lecturer()
        {
            InitializeComponent();
            LecturerController controller = new LecturerController();
            dgv_lecturer.DataSource = controller.GetAllLecturers();

            if (HideRole.role == "Lecture" || HideRole.role == "Student")
            {
                btn_add.Visible = false;
                btn_update.Visible = false;
                btn_delete.Visible = false;
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btn_add_letc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_letc_name.Text) ||
                string.IsNullOrWhiteSpace(txt_letc_addres.Text) ||
                string.IsNullOrWhiteSpace(txt_letc_nic.Text))
            {
                MessageBox.Show("Please enter all details.");
                return;
            }

            var lecturer = new Lecture
            {
                Name = txt_letc_name.Text,
                Address = txt_letc_addres.Text,
                NIC = txt_letc_nic.Text
            };

            LecturerController controller = new LecturerController();
            controller.AddLecturer(lecturer);

            MessageBox.Show("Lecturer added successfully.");

            
            txt_letc_name.Text = "";
            txt_letc_addres.Text = "";
            txt_letc_nic.Text = "";

            
            dgv_lecturer.DataSource = controller.GetAllLecturers();
        }

        private void txt_letc_nic_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_update_lect_Click(object sender, EventArgs e)
        {
            if (UpdateLecturerId == null)
            {
                MessageBox.Show("Please select a lecturer to update.");
                return;
            }

            var lecturer = new Lecture
            {
                Id = Convert.ToInt32(UpdateLecturerId),
                Name = txt_letc_name.Text,
                Address = txt_letc_addres.Text,
                NIC = txt_letc_nic.Text
            };

            LecturerController controller = new LecturerController();
            controller.UpdateLecturer(lecturer);

            MessageBox.Show("Lecturer updated successfully.");

            txt_letc_name.Text = "";
            txt_letc_addres.Text = "";
            txt_letc_nic.Text = "";

            dgv_lecturer.DataSource = controller.GetAllLecturers();
        }

        private void btn_delete_lect_Click(object sender, EventArgs e)
        {
            if (UpdateLecturerId == null)
            {
                MessageBox.Show("Please select a lecturer to delete.");
                return;
            }

            LecturerController controller = new LecturerController();
            controller.DeleteLecturer(Convert.ToInt32(UpdateLecturerId));

            MessageBox.Show("Lecturer deleted successfully.");

            
            txt_letc_name.Text = "";
            txt_letc_addres.Text = "";
            txt_letc_nic.Text = "";

            
            dgv_lecturer.DataSource = controller.GetAllLecturers();
        }

        private void dgv_lecturer_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_lecturer.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_lecturer.SelectedRows[0];

                txt_letc_name.Text = selectedRow.Cells["Name"].Value?.ToString() ?? "";
                txt_letc_addres.Text = selectedRow.Cells["Address"].Value?.ToString() ?? "";
                txt_letc_nic.Text = selectedRow.Cells["NIC"].Value?.ToString() ?? "";

                
                if (int.TryParse(selectedRow.Cells["Id"].Value?.ToString(), out int id))
                {
                    UpdateLecturerId = id;
                }
                else
                {
                    UpdateLecturerId = null;
                }
            }
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {

        }
    }

}



