using C__project_1.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Repositories
{

    public static class DatabaseManager
    {
        public static void CreateTables()
        {
            string createTables = @"               

                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Role TEXT NOT NULL,
                    Username TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Courses (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT NOT NULL,
                    Department TEXT
                );

                CREATE TABLE IF NOT EXISTS Subjects (
                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT NOT NULL,
                    CourseID INTEGER,
                    FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                );

                CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectID INTEGER,
                    ExamDate TEXT,
                    RoomID INTEGER,
                    FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                    FOREIGN KEY(RoomID) REFERENCES Rooms(RoomID)
                );

                CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER,
                    ExamID INTEGER,
                    MarksObtained INTEGER,
                    FOREIGN KEY(StudentID) REFERENCES Students(Id),
                    FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
                );

                CREATE TABLE IF NOT EXISTS Rooms (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT NOT NULL,
                    RoomType TEXT NOT NULL 
                );

                CREATE TABLE IF NOT EXISTS Timetables (
                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectID INTEGER,
                    TimeSlot TEXT,
                    RoomID INTEGER,
                    FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                    FOREIGN KEY(RoomID) REFERENCES Rooms(RoomID)
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

                CREATE TABLE IF NOT EXISTS Lecturer (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Address TEXT NOT NULL,
                    NIC TEXT NOT NULL,
                    SubjectID INTEGER,
                    FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                );

                CREATE TABLE IF NOT EXISTS Teachers (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Address TEXT NOT NULL,
                    NIC TEXT NOT NULL
                );
            ";

            string insertSampleData = @"
                INSERT OR IGNORE INTO Courses (CourseID, CourseName, Department) VALUES (1, 'BSc Computer Science', 'IT');

                INSERT OR IGNORE INTO Subjects (SubjectID, SubjectName, CourseID) VALUES (1, 'Programming', 1);
                INSERT OR IGNORE INTO Subjects (SubjectID, SubjectName, CourseID) VALUES (2, 'Math', 1);
                INSERT OR IGNORE INTO Subjects (SubjectID, SubjectName, CourseID) VALUES (3, 'physics', 1);
                INSERT OR IGNORE INTO Subjects (SubjectID, SubjectName, CourseID) VALUES (4, 'software devolpment', 1);

                INSERT OR IGNORE INTO Rooms (RoomID, RoomName, RoomType) VALUES (1, 'Lab 1', 'Lab');
                
                INSERT OR IGNORE INTO Rooms (RoomID, RoomName, RoomType) VALUES (2, 'Lab 2', 'Lab');
                INSERT OR IGNORE INTO Rooms (RoomID, RoomName, RoomType) VALUES (3, 'Lab 3', 'Lab');
                INSERT OR IGNORE INTO Rooms (RoomID, RoomName, RoomType) VALUES (4, 'Hall A', 'Hall');
                INSERT OR IGNORE INTO Rooms (RoomID, RoomName, RoomType) VALUES (5, 'Hall B', 'Hall');
                INSERT OR IGNORE INTO Rooms (RoomID, RoomName, RoomType) VALUES (6, 'Hall c', 'Hall');
                
            ";



            using (var conn = Database.GetConnection())
            {                
                conn.Open();

                // Step 1: Create Tables
                using (var cmd = new SQLiteCommand(createTables, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Step 2: Insert Sample Data
                using (var cmd = new SQLiteCommand(insertSampleData, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Step 3: Insert default users if not exist
                string checkUsersExist = "SELECT COUNT(*) FROM Users;";
                using (var checkCmd = new SQLiteCommand(checkUsersExist, conn))
                {
                    long userCount = (long)checkCmd.ExecuteScalar();
                    if (userCount == 0)
                    {
                        string[] roles = { "Admin", "Lecturer", "Staff", "Student" };
                        string[] usernames = { "admin", "lecturer", "staff", "student" };
                        string[] passwords = { "admin@123", "lecturer@123", "staff@123", "student@123" };

                        for (int i = 0; i < roles.Length; i++)
                        {
                            string insertQuery = "INSERT INTO Users (Role, Username, Password) VALUES (@role, @username, @password)";
                            using (var insertCmd = new SQLiteCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@role", roles[i]);
                                insertCmd.Parameters.AddWithValue("@username", usernames[i]);
                                insertCmd.Parameters.AddWithValue("@password", passwords[i]);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
    }
}


