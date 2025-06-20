using C__project_1.Controler;
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
    public partial class Course___Subject : Form
    {
        public Course___Subject()
        {
            InitializeComponent();
            CourseController controller = new CourseController();
           
            comboBox1.Items.Clear();
            comboBox1.Items.Add("BSC Maths");
            comboBox1.Items.Add("BSC Chemistry");
            comboBox1.Items.Add("IT");
            comboBox1.Items.Add("English");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}





