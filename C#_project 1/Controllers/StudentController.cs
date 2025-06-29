﻿using C__project_1.Repositories;
using C__project_1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__project_1.Controler
{
    public class StudentController
    {
        public void AddStudent(Student student)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Students (Name, Address, NIC) VALUES (@name, @address, @NIC)";
                    cmd.Parameters.AddWithValue("@name", student.Name);
                    cmd.Parameters.AddWithValue("@address", student.Address);
                    cmd.Parameters.AddWithValue("@NIC", student.NIC);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Students";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Address = reader.GetString(2),
                                NIC = reader.GetString(3)
                            });
                        }
                    }
                }
            }
            return students;
        }

        public void UpdateStudent(Student student)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Students SET Name = @name, Address = @address, NIC = @NIC WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@name", student.Name);
                    cmd.Parameters.AddWithValue("@address", student.Address);
                    cmd.Parameters.AddWithValue("@NIC", student.NIC);
                    cmd.Parameters.AddWithValue("@id", student.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStudent(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Students WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }



           
        }
    }
}


