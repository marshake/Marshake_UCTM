using C__project_1.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    public static class DatabaseManager
    {
        public static void CreateTables()
        {
            using (var conn = Database.GetConnection())
            {               

                string createTables = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        user_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        username TEXT NOT NULL,
                        password TEXT NOT NULL,
                        role TEXT
                    );

                    CREATE TABLE IF NOT EXISTS Courses (
                        course_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        course_name TEXT NOT NULL,
                        department TEXT
                    );

                    CREATE TABLE IF NOT EXISTS Subjects (
                        subject_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        subject_name TEXT NOT NULL,
                        course_id INTEGER,
                        FOREIGN KEY(course_id) REFERENCES Courses(course_id)
                    );

                    CREATE TABLE IF NOT EXISTS Exams (
                        exam_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        subject_id INTEGER,
                        exam_date TEXT,
                        room_id INTEGER,
                        FOREIGN KEY(subject_id) REFERENCES Subjects(subject_id),
                        FOREIGN KEY(room_id) REFERENCES Rooms(room_id)
                    );

                    CREATE TABLE IF NOT EXISTS Marks (
                        mark_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        student_id INTEGER,
                        exam_id INTEGER,
                        marks_obtained INTEGER,
                        FOREIGN KEY(student_id) REFERENCES Students(Id),
                        FOREIGN KEY(exam_id) REFERENCES Exams(exam_id)
                    );

                    CREATE TABLE IF NOT EXISTS Rooms (
                        room_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        room_name TEXT NOT NULL,
                        capacity INTEGER
                    );

                    CREATE TABLE IF NOT EXISTS Timetables (
                        timetable_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        course_id INTEGER,
                        subject_id INTEGER,
                        day TEXT,
                        time TEXT,
                        room_id INTEGER,
                        FOREIGN KEY(course_id) REFERENCES Courses(course_id),
                        FOREIGN KEY(subject_id) REFERENCES Subjects(subject_id),
                        FOREIGN KEY(room_id) REFERENCES Rooms(room_id)
                    );

                    CREATE TABLE IF NOT EXISTS Students (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        NIC TEXT NOT NULL
                    );
                    CREATE TABLE IF NOT EXISTS Staff (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Address TEXT NOT NULL,
                    NIC TEXT NOT NULL
                    );
                ";

                using (var cmd = new SQLiteCommand(createTables, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}