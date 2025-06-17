using C__project_1.Controler;
using C__project_1.Controllers;
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // You can implement functionality 
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

            var lecturer = new Models.Lecturer
            {
                Name = txt_letc_name.Text,
                Address = txt_letc_addres.Text,
                NIC = txt_letc_nic.Text
            };

            LecturerController controller = new LecturerController();
            controller.AddLecturer(lecturer);

            MessageBox.Show("Lecturer added successfully.");

            // Clear form
            txt_letc_name.Text = "";
            txt_letc_addres.Text = "";
            txt_letc_nic.Text = "";

            // Refresh grid
            dgv_lecturer.DataSource = controller.GetAllLecturers();
        }

        private void txt_letc_nic_TextChanged(object sender, EventArgs e)
        {
            // You can implement validation or other logic here
        }

        private void btn_update_lect_Click(object sender, EventArgs e)
        {
            if (UpdateLecturerId == null)
            {
                MessageBox.Show("Please select a lecturer to update.");
                return;
            }

            var lecturer = new Models.Lecturer
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

            // Clear form
            txt_letc_name.Text = "";
            txt_letc_addres.Text = "";
            txt_letc_nic.Text = "";

            // Refresh grid
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

                // Set the UpdateStudentId for update/delete operations
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
    }

}



