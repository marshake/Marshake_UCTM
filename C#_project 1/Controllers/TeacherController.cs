using C__project_1.Models;
using C__project_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__project_1.Controllers
{
    internal class TeacherController
    {
        public void AddTeacher(Teacher teacher)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Teachers (Name, Address, NIC) VALUES (@name, @address, @NIC)";
                    cmd.Parameters.AddWithValue("@name", teacher.Name);
                    cmd.Parameters.AddWithValue("@address", teacher.Address);
                    cmd.Parameters.AddWithValue("@NIC", teacher.NIC);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Teachers";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachers.Add(new Teacher
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
            return teachers;
        }

        public void UpdateTeacher(Teacher teacher)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Teachers SET Name = @name, Address = @address, NIC = @NIC WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@name", teacher.Name);
                    cmd.Parameters.AddWithValue("@address", teacher.Address);
                    cmd.Parameters.AddWithValue("@NIC", teacher.NIC);
                    cmd.Parameters.AddWithValue("@id", teacher.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTeacher(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Teachers WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}