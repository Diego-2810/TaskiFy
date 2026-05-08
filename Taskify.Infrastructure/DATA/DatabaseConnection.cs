using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace Taskify.Infrastructure.DATA
{
    public class DatabaseConnection
    {
        private readonly IConfiguration _configuration;
        public DatabaseConnection(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public MySqlConnection CreateConnection()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            return new MySqlConnection(connectionString);
        }
    }
}