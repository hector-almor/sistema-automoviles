using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_automóviles.Models.Models
{
    internal class DB
    {
        string _connectionString = "Server=localhost; Database=sistema_automoviles; " +
            "Uid=root; Pwd=Soyelsysadmin";
        protected MySqlConnection? _connection;
        public void Connect()
        {
            _connection = new MySqlConnection(_connectionString);
            _connection.Open();
        }
        public void Close()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }
    }
}
