using C__project_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__project_1.Controllers
{
    internal class StaffController
    {
        public void AddStaff(Models.Staff staff)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Staff (Name, Address, NIC) VALUES (@name, @address, @NIC)";
                    cmd.Parameters.AddWithValue("@name", staff.Name);
                    cmd.Parameters.AddWithValue("@address", staff.Address);
                    cmd.Parameters.AddWithValue("@NIC", staff.NIC);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Models.Staff> GetAllStaff()
        {
            List<Models.Staff> staffList = new List<Models.Staff>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Staff";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            staffList.Add(new Models.Staff
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
            return staffList;
        }

        public void UpdateStaff(Models.Staff staff)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Staff SET Name = @name, Address = @address, NIC = @NIC WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@name", staff.Name);
                    cmd.Parameters.AddWithValue("@address", staff.Address);
                    cmd.Parameters.AddWithValue("@NIC", staff.NIC);
                    cmd.Parameters.AddWithValue("@id", staff.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStaff(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();  

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Staff WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}