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
    public partial class DashBoard : Form
    {
        private User currentUser;

        public User User { get; }



        public DashBoard(User user)
        {
            InitializeComponent();
            currentUser = user; // ✅ Fix: use the parameter, not the property
            SetButtonAccessBasedOnRole();
        }

        private void SetButtonAccessBasedOnRole()
        {
            btn_student.Enabled = false;
            btn_staff.Enabled = false;
            btn_lecture.Enabled = false;
            btn_teacher.Enabled = false;
            btn_Exam.Enabled = false;
            btn_marks.Enabled = false;
            btn_tt.Enabled = false;
            button1.Enabled = false; // Course button (assuming button1 = btn_course)
            
            switch (currentUser.Role)
            {
                case "Admin":
                    // Admin can do everything
                    btn_student.Enabled = true;
                    btn_staff.Enabled = true;
                    btn_lecture.Enabled = true;
                    btn_teacher.Enabled = true;
                    btn_Exam.Enabled = true;
                    btn_marks.Enabled = true;
                    btn_tt.Enabled = true;
                    button1.Enabled = true;
                    break;

                case "Staff":
                    btn_Exam.Enabled = true;
                    btn_marks.Enabled = true;
                    btn_tt.Enabled = true;
                    btn_student.Enabled = true;
                    break;

                case "Lecture":
                    btn_marks.Enabled = true;
                    btn_tt.Enabled = true;
                    btn_student.Enabled = true;
                    btn_Exam.Enabled = true;
                    break;

                case "Student":
                    btn_tt.Enabled = true;
                    btn_marks.Enabled = true;
                    btn_student.Enabled = true;
                    btn_Exam.Enabled = true;
                    break;

                default:
                    MessageBox.Show("Unknown role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public void LoadForm(object formObj)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                var oldForm = this.mainpanel.Controls[0] as Form;
                if (oldForm != null)
                {
                    oldForm.Close();
                    oldForm.Dispose();
                }
                this.mainpanel.Controls.Clear();
            }

            Form form = formObj as Form;
            if (form != null)
            {
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;  // remove borders to fit nicely
                form.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(form);
                this.mainpanel.Tag = form;
                form.Show();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadForm(new Staff());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new Student());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new Teacher());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadForm(new Lecturer());
        }

        private void btn_marks_Click(object sender, EventArgs e)
        {
            LoadForm(new Mark());
        }

        private void btn_tt_Click(object sender, EventArgs e)
        {
            LoadForm(new Timetable());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btn_Exam_Click(object sender, EventArgs e)
        {
            LoadForm(new Exam());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new Course___Subject());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Exam_Click_1(object sender, EventArgs e)
        {
            LoadForm(new Exam());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            LoadForm(new Course___Subject());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



