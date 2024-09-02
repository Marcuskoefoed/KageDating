using KageDating.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KageDating.Services
{
    public interface IAuthService
    {
        bool IsLoggedIn { get; }
        Task<User> Authenticate(string username, string password);
        Task<List<User>> GetUsersAsync();
        int? GetCurrentUserId();
        void Logout();
    }

    public class AuthService : IAuthService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private bool _isLoggedIn = false;
        private int? _currentUserId = null;
        private readonly DataContext _context;

        public AuthService(IHttpContextAccessor httpContextAccessor, DataContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        public bool IsLoggedIn => _isLoggedIn;

        public int? GetCurrentUserId()
        {
            return _currentUserId;
        }

        public async Task<User> Authenticate(string username, string password)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == username && u.Password == password);

            if (user != null)
            {
                _isLoggedIn = true;
                _currentUserId = user.UserId;
            }

            return user;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public void Logout()
        {
            _isLoggedIn = false;
            _currentUserId = null;
        }
    }
}

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}
