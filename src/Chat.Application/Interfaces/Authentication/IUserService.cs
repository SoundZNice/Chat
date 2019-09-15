using System.Threading.Tasks;
using Chat.Domain;

namespace Chat.Application.Interfaces
{
    public interface IUserService
    {
        //TODO: Add find by email or user name
        Task<User> FindUserAsync(string email, string password);
    }
}
