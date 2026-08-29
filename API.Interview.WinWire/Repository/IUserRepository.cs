using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interview.WinWire.Models;

namespace API.Interview.WinWire.Repository
{

    // Use a repository design pattern to define an IUserRepository abstraction that asynchronously returns a User object given a user identifier.
    public interface IUserRepository
    {
        Task<User> GetUserAsync(int id, CancellationToken cancellationToken = default);
    }
}