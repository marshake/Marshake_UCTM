﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__project_1.Repositories
{
    public static class Database
    {
        public static string ConnectionString = "Data Source=unicomticDB_new.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {

            
            var conn = new SQLiteConnection(ConnectionString);
            return conn;
        }
    }
}