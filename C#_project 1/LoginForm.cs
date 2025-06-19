using C__project_1.Controler;
using C__project_1.Models;
using C__project_1.viwes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__project_1.Views
{
    public partial class LoginForm : Form
    {
        private LoginController loginController = new LoginController();
        public LoginForm()
        {
            InitializeComponent();
            cmb_role.Items.Clear();
            cmb_role.Items.Add("Admin");
            cmb_role.Items.Add("Staff");
            cmb_role.Items.Add("Lecture");
            cmb_role.Items.Add("Student");
            cmb_role.SelectedIndex = 0;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TXT_USERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            string username = TXT_USERNAME.Text.Trim();
            string password = TXT_PASSWORD.Text.Trim();
            string role = cmb_role.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please enter all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = loginController.Authenticate(username, password, role);

            if (user != null)
            {
                MessageBox.Show($"Login successful as {user.Role}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DashBoard dashboard = new DashBoard(user);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXT_PASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}


            



         
         
        
    

    


