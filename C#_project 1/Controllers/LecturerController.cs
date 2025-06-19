using C__project_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__project_1.Controllers
{
    internal class LecturerController
    {
        public void AddLecturer(Models.Lecturer lecturer)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  // Open the connection before using it

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Lecturer (Name, Address, NIC) VALUES (@name, @address, @NIC)";
                    cmd.Parameters.AddWithValue("@name", lecturer.Name);
                    cmd.Parameters.AddWithValue("@address", lecturer.Address);
                    cmd.Parameters.AddWithValue("@NIC", lecturer.NIC);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Models.Lecturer> GetAllLecturers()
        {
            List<Models.Lecturer> lecturers = new List<Models.Lecturer>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();  // Open connection

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Lecturer";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lecturers.Add(new Models.Lecturer
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
            return lecturers;
        }

        public void UpdateLecturer(Models.Lecturer lecturer)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  // Open connection

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Lecturer SET Name = @name, Address = @address, NIC = @NIC WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@name", lecturer.Name);
                    cmd.Parameters.AddWithValue("@address", lecturer.Address);
                    cmd.Parameters.AddWithValue("@NIC", lecturer.NIC);
                    cmd.Parameters.AddWithValue("@id", lecturer.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteLecturer(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  // Open connection

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Lecturer WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}






