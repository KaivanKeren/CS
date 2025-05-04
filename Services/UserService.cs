using Microsoft.Extensions.Logging;
using CS.Model;

namespace CS.Services
{
    public class UserService
    {
        private readonly ILogger<UserService> _logger;

        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
        }

        public async Task<User> GetUserAsync()
        {
            await Task.Delay(1000);
            _logger.LogInformation("Fetched user data.");
            return new User { Name = "Ismail", Age = 17 };
        }
    }
}