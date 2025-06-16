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

namespace C__project_1.viwes
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        public void LoadForm(object formObj)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(form);
            this.mainpanel.Tag = form;
            form.Show();
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
    }
}
