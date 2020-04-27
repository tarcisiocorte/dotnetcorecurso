using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    private readonly DataContext _context;
    public AuthRepository(DataContext context)
    {
        _context = context;        
    }
    public class AuthRepository : IAuthRepository
    {
        public Task<User> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Register(User user, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UserExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}