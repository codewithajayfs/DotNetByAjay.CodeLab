using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interview.WinWire.Models;
using API.Interview.WinWire.Repository;

namespace API.Interview.WinWire.Services
{
    // Define a UserService class object
    public class UserService
    {
        // TODO: Add the required dependencies
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserService> _logger;
        public UserService(IUserRepository userRepository, ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<string> GetUserEmailAsync(int userId, CancellationToken cancellationToken = default)
        {
            // TODO: Add a try/catch block around the user retrieval logic
            try
            {
                // TODO: Ensure the user identifier is non-zero
                if (userId == 0)
                {
                    throw new ArgumentException($"User identifier must be non-zero. UserId: {userId}", nameof(userId));
                }

                // TODO: Use UserRepository to retrieve the user • by user. identifier and return the email by user identifier.
                User user = await _userRepository.GetUserAsync(userId, cancellationToken);

                if (user == null)
                {
                    _logger.LogWarning($"User not found. UserId {userId}");
                    // TODO: Log a warning and throw an InvalidoperationException if the user does not exist.
                    throw new InvalidOperationException($"User does not exist. UserId: {userId}");
                }

                return user.Email;
            }
            // TODO: Log a warning and throw an InvalidoperationException if the user does not exist.
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                // Include the user identifier within the 1og/ exception messages
                // TODO: Log an error and throw an InvalidoperationException if a failure occurs retrieving the user.
                // Include the user identifier within the log/exception messages
                _logger.LogError(ex, "Failed to retrieve user. UserId: {UserId}", userId);
                throw new InvalidOperationException($"Failed to retrieve user. UserId: {userId}", ex);
            }

        }







    }
}