using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Chat.Application.Interfaces.Authentication;
using Chat.Application.Models;
using Chat.Domain;

namespace Chat.Application.Authentication
{
    public class TokenFactoryService : ITokenFactoryService
    {
        public Task<JwtTokenData> CreateJwtTokensAsync(User user)
        {
            throw new System.NotImplementedException();
        }

        private Task<(string accessToken, IEnumerable<Claim> claims)> GetAccessToken(User user)
        {
            var claims =
        }
    }
}
