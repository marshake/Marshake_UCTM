﻿using C__project_1.Controler;
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
            cmb_coure.Items.Clear();
            cmb_coure.Items.Add("BSC Maths");
            cmb_coure.Items.Add("BSC Chemistry");
            cmb_coure.Items.Add("IT");
            cmb_coure.Items.Add("English");
            cmb_coure.SelectedIndex = 0;
            if (HideRole.role == "Lecture" || HideRole.role == "Staff" || HideRole.role == "Student")
            {
                btn_add.Visible = false;
                btn_delete.Visible = false;
                btn_update.Visible = false;
            }
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

            
            txt_studentname.Text = "";
            txt_studentAddress.Text = "";
            txt_studentNIC.Text = "";

            
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

            
            txt_studentname.Text = "";
            txt_studentAddress.Text = "";
            txt_studentNIC.Text = "";

            
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void back_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void cmb_coure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



        

    

 


