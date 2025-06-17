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
            string[,] credndials = new string[,]
            {
                {"Admin","admin","admin@123" },
                {"Lecture","lecture","lecture@123" },
                {"Staff","staff","staff@123" },
                {"Student","student","tudent@123" }

            };


            
            string role = cmb_role.Text.Trim();
            string username = TXT_USERNAME.Text.Trim();
            string password = TXT_PASSWORD.Text.Trim();
           

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter all fields.", "validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isValid = false;
            for (int i = 0; i < credndials.GetLength(0); i++)
            {
                if (credndials[i, 0] == role &&
                    credndials[i, 1] == username &&
                    credndials[i, 2] == password)
                {
                    isValid = true;
                    break;
                }
            }
            if (isValid)
            {
                MessageBox.Show($"Login succesfull as {role}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashBoard dashboard = new DashBoard(role);
                dashboard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid credetials.please try agin", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                role.Clone();
                username.Normalize();
                password.Normalize();
            }





            
        }

        private void cmb_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}


            



         
         
        
    

    


