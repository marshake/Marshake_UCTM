using C__project_1.Models;
using C__project_1.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__project_1.Controler
{
    internal class TimetableController
    {
        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Subjects";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            SubjectID = reader.GetInt32(0),
                            SubjectName = reader.GetString(1)
                        });
                    }
                }
            }
            return subjects;
        }

        
        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Rooms";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new Room
                        {
                            RoomID = reader.GetInt32(0),
                            RoomName = reader.GetString(1),
                            RoomType = reader.GetString(2)
                        });
                    }
                }
            }
            return rooms;
        }

       
        public void AddTimetable(Timetable timetable)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) VALUES (@subjectID, @timeSlot, @roomID)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@subjectID", timetable.SubjectID);
                    command.Parameters.AddWithValue("@timeSlot", timetable.TimeSlot);
                    command.Parameters.AddWithValue("@roomID", timetable.RoomID);
                    command.ExecuteNonQuery();
                }
            }
        }

        
        public List<TimetableViewModel> GetTimetableList()
        {
            List<TimetableViewModel> list = new List<TimetableViewModel>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                string query = @"SELECT t.TimeSlot, s.SubjectName, r.RoomName
                                 FROM Timetables t
                                 JOIN Subjects s ON t.SubjectID = s.SubjectID
                                 JOIN Rooms r ON t.RoomID = r.RoomID";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TimetableViewModel
                        {
                            Subject = reader.GetString(1),
                            TimeSlot = reader.GetString(0),
                            Room = reader.GetString(2)
                        });
                    }
                }
            }
            return list;
        }
    }
}

