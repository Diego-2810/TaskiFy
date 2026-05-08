using System.Runtime.CompilerServices;
using Dapper;
using Taskify.Core.Entities;
using Taskify.Core.Interfaces;
using Taskify.Infrastructure.DATA;

namespace Taskify.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        public UserRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            using var connection = _databaseConnection.CreateConnection();
            string query = "SELECT * FROM Users";
            var users = await connection.QueryAsync<User>(query);
            return users;
        }

        public async Task CreateAsync(User user)
        {
            using var connection = _databaseConnection.CreateConnection();
            string query = @"
                INSERT INTO users (Username, Email, password_Hash)
                VALUES (@Username, @Email, @PasswordHash)";
            await connection.ExecuteAsync(query, user);
        }

        public async Task<User> GetEmailAsync(string email)
        {
            using var connection = _databaseConnection.CreateConnection();
            string query = "SELECT * FROM Users WHERE Email = @Email";
            return await connection.QueryFirstOrDefaultAsync<User>(query, new { Email = email });
        }
    }
}