using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interview.WinWire.Models;

namespace API.Interview.WinWire.Repository
{
    public class UserRepository : IUserRepository
    {
        public Task<User> GetUserAsync(int id, CancellationToken cancellationToken = default)
        {
            var user = new User()
            {
                Id = id,
                Email = "ajay@email.com"
            };

            return Task.FromResult(user);
        }
    }
}