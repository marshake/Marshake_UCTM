using C__project_1.Controler;
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
    public partial class TimetableForm : Form
    {
        TimetableController controller = new TimetableController();
        public TimetableForm()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimetableForm_Load(object sender, EventArgs e)
        {
            cmbSubject.DataSource = controller.GetAllSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";

            cmbRoom.DataSource = controller.GetAllRooms();
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomID";

            LoadTimetables();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedValue != null && cmbRoom.SelectedValue != null && !string.IsNullOrWhiteSpace(txtTimeSlot.Text))
            {
                var timetable = new Timetable
                {
                    SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                    TimeSlot = txtTimeSlot.Text.Trim(),
                    RoomID = Convert.ToInt32(cmbRoom.SelectedValue)
                };

                controller.AddTimetable(timetable);

                MessageBox.Show("Timetable entry added successfully!");
                txtTimeSlot.Clear();
                LoadTimetables();
            }
            else
            {
                MessageBox.Show("Please fill all fields before adding.");
            }
        }

        private void LoadTimetables()
        {
            var list = controller.GetTimetableList();

            gridTimetables.DataSource = list
                .Select(t => new
                {
                    Subject = t.Subject,
                    TimeSlot = t.TimeSlot,
                    Room = t.Room
                })
                .ToList();
        }
    }
}