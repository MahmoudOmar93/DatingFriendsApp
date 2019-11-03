using System.Threading.Tasks;
using DatingFriendsApp.API.Models;

namespace DatingFriendsApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}