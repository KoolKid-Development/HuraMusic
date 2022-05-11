using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace HuraMusic
{
    public class Authentication
    {
        public string connectionString { get; set; }
        string connection;

        public void getConnection()
        {
            connection = @"Data Source=Account.db; Version=3";
            connectionString = connection;
        }
    }
}
