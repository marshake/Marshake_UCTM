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
    public partial class Staff : Form
    {
        public object UpdateStaffId { get; private set; }

        public Staff()
        {
            InitializeComponent();
           StaffController controller = new StaffController();
            dgv_staff.DataSource = controller.GetAllStaff();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var staff = new Models.Staff
            {
                Name = txt_staffname.Text,
                Address = txt_staffAddress.Text,
                NIC = txt_staffNIC.Text,
                Id = Convert.ToInt32(UpdateStaffId)
            };

            StaffController controller = new StaffController();
            controller.UpdateStaff(staff);
            MessageBox.Show("Staff updated successfully.");

            txt_staffname.Text = "";
            txt_staffAddress.Text = "";
            txt_staffNIC.Text = "";

            dgv_staff.DataSource = controller.GetAllStaff();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UpdateStaffId == null)
            {
                MessageBox.Show("Please select a staff member to delete.");
                return;
            }

            StaffController controller = new StaffController();
            controller.DeleteStaff(Convert.ToInt32(UpdateStaffId));

            MessageBox.Show("Staff deleted successfully.");

            txt_staffname.Text = "";
            txt_staffAddress.Text = "";
            txt_staffNIC.Text = "";

            dgv_staff.DataSource = controller.GetAllStaff();
        }

        private void btn_add_stf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_staffname.Text) ||
                string.IsNullOrWhiteSpace(txt_staffAddress.Text) ||
                string.IsNullOrWhiteSpace(txt_staffNIC.Text))
            {
                MessageBox.Show("Please enter all details.");
                return;
            }

            var staff = new Models.Staff
            {
                Name = txt_staffname.Text,
                Address = txt_staffAddress.Text,
                NIC = txt_staffNIC.Text
            };

            StaffController controller = new StaffController();
            controller.AddStaff(staff);

            MessageBox.Show("Staff added successfully.");

            txt_staffname.Text = "";
            txt_staffAddress.Text = "";
            txt_staffNIC.Text = "";

            dgv_staff.DataSource = controller.GetAllStaff();
        }

        private void dgv_staff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_staff.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_staff.SelectedRows[0];

                txt_staffname.Text = selectedRow.Cells["Name"].Value?.ToString() ?? "";
                txt_staffAddress.Text = selectedRow.Cells["Address"].Value?.ToString() ?? "";
                txt_staffNIC.Text = selectedRow.Cells["NIC"].Value?.ToString() ?? "";

                
                if (int.TryParse(selectedRow.Cells["Id"].Value?.ToString(), out int id))
                {
                    UpdateStaffId = id;
                }
                else
                {
                    UpdateStaffId = null;
                }
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_stf_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
