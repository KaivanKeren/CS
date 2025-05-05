using CS.AppContext;
using Microsoft.Extensions.Logging;
using CS.Model;
using Microsoft.EntityFrameworkCore;

namespace CS.Services
{
    public class UserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly MyDBContext _context;

        public UserService(ILogger<UserService> logger, MyDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            var users = await _context.users.ToListAsync();
            _logger.LogInformation("Fetched {Count} user(s) from DB.", users.Count);
            return users;
        }

        public async Task AddUserAsync(User user)
        {
            _context.users.Add(user);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Added user {Name} to DB.", user.Name);
        }
    }
}