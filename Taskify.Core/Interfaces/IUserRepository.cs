using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taskify.Core.Entities;

namespace Taskify.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task CreateAsync(User user);
        Task<User> GetEmailAsync(string email);
    }
}