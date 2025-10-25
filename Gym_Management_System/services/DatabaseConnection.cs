using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System.services
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _lock = new object();
        private readonly string _connectionString = @"Data Source=DESKTOP-8T2OQ4F;Initial Catalog=student;Integrated Security=True;Encrypt=False";
        private SqlConnection _connection;

      
        private DatabaseConnection()
        {
            _connection = new SqlConnection(_connectionString);
            //CreateUserTableIfNotExists();
        }

       
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

        private void CreateUserTableIfNotExists()
        {
            DatabaseConnection.Instance.GetConnection();

            string createTableQuery = @"
                            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='users' AND xtype='U')
                            BEGIN
                                CREATE TABLE users (
                                    userid INT IDENTITY(1,1) PRIMARY KEY,
                                    username VARCHAR(50),
                                    password VARCHAR(255),
                                    email VARCHAR(100),
                                    role VARCHAR(50),
                                    name VARCHAR(50),
                                    age INT,
                                    contact VARCHAR(50),
                                    height DECIMAL(5,2),
                                    weight DECIMAL(5,2),
                                    gender VARCHAR(50),
                                    bloodgrp VARCHAR(50),
                                    trainer VARCHAR(50),
                                    photo VARBINARY(MAX)
                                )
                            END";

            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            {
                try
                {

                    using (SqlCommand cmd = new SqlCommand(createTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Table creation failed: " + ex.Message);
                }
            }
        }


        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }
    }

}
