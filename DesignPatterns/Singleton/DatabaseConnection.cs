using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _lock = new object();

        private string _connectionString;

        private DatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
            Console.WriteLine("Database Connection Created with Connection String: " + _connectionString);
        }

        public static DatabaseConnection GetInstance(string connectionString)
        {
            // Thread-safe
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new DatabaseConnection(connectionString);
                }
            }
            return _instance;
        }

        
        public void OpenConnection()
        {
            Console.WriteLine("Opening database connection...");
            
        }

        
        public void CloseConnection()
        {
            Console.WriteLine("Closing database connection...");
            
        }
    }
}
