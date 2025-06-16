using C__project_1.Models;
using C__project_1.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace C__project_1.Controler
{
   public class LoginController
   {
        public User Authenticate(string username, string password)
        {
            

            using (var connection = Database.GetConnection())
            {
                

                
                string query = "SELECT Username, Password, Role FROM Users WHERE Username=@username AND Password=@password";

                using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        
                        return new User
                        {
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                    }
                }
            }
            
            return null;
        }
   }
}
