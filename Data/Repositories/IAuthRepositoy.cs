using System.Threading.Tasks;
using PresentationCreatorWeb.Data.Models;

namespace PresentationCreatorWeb.Data.Repositories
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> LoginByEmail(string email, string password);
         Task<bool> UserExistByEmail(string email);
    }
}