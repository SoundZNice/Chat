using System.Threading.Tasks;
using Chat.Application.Models;
using Chat.Domain;

namespace Chat.Application.Interfaces.Authentication
{
    public interface ITokenFactoryService
    {
        Task<JwtTokenData> CreateJwtTokensAsync(User user);
    }
}
