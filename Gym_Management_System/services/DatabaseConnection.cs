using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.services
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _lock = new object();
        private readonly string _connectionString = @"Data Source=DESKTOP-UTSQ2RQ\SQLEXPRESS;Initial Catalog=student;Integrated Security=True";
        private SqlConnection _connection;

        // Private constructor
        private DatabaseConnection()
        {
            _connection = new SqlConnection(_connectionString);
        }

        // Get the single instance
        public static DatabaseConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new DatabaseConnection();
                    return _instance;
                }
            }
        }

        public SqlConnection GetConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed || _connection.State == System.Data.ConnectionState.Broken)
            {
                _connection.Open();
            }
            return _connection;
        }

        // Optional: Close the connection manually
        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }
    }

}
