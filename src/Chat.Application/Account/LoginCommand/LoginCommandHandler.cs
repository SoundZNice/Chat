using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Chat.Application.Interfaces;
using Chat.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Chat.Application.Account.LoginUserCommand
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginCommandResult>
    {
        private readonly IChatDbContext _context;

        public LoginCommandHandler(IChatDbContext context)
        {
            _context = context;
        }

        public async Task<LoginCommandResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            User user = await FindUserAsync(request.Email, request.Password);

            //TODO: Add user deactivation
            if (user == null)
            {
                return new LoginCommandResult { Succeeded = false };
            }

            throw new NotImplementedException(nameof(LoginCommandHandler));
        }

        private async Task CreateJwtTokenAsync(User user)
        {

        }

        private async Task CreateAccessTokenAsync(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                //new Claim(JwtRegisteredClaimNames)
            };

            //string key = new SymmetricSecurityKey();

            throw new NotImplementedException(nameof(CreateAccessTokenAsync));
        }

        private async Task<User> FindUserAsync(string email, string password)
        {
            string hash = GetSha256Hash(password);
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email && x.PasswordHash == hash);
        }

        private string GetSha256Hash(string input)
        {
            using (var hashAlgorithm = new SHA256CryptoServiceProvider())
            {
                byte[] byteInput = Encoding.UTF8.GetBytes(input);
                byte[] hash = hashAlgorithm.ComputeHash(byteInput);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
