using Chat.Application.Interfaces.Authentication;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Chat.Application.Authentication
{
    public class SecurityService : ISecurityService
    {
        private readonly RandomNumberGenerator _random = RandomNumberGenerator.Create();

        public string GetSha256Hash(string input)
        {
            using (var hashAlgorithm = new SHA256CryptoServiceProvider())
            {
                byte[] inputByte = Encoding.UTF8.GetBytes(input);
                byte[] hash = hashAlgorithm.ComputeHash(inputByte);
                return Convert.ToBase64String(hash);
            }
        }

        public Guid CreateCryptographicallySecureGuid()
        {
            byte[] bytes = new byte[16];
            _random.GetBytes(bytes);
            return new Guid(bytes);
        }
    }
}
