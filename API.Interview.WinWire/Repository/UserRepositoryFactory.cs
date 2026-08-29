using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interview.WinWire.Repository
{
    // Use a creational design pattern to create an IUserRepository instance.
    // Factory Pattern
    public static class UserRepositoryFactory
    {
        public static IUserRepository Create()
        {
            return new UserRepository();
        }
    }
}