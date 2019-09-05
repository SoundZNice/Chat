using Chat.Application.Interfaces.Authentication;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Chat.Application.Authentication
{
    public class SecurityService : ISecurityService
    {
        public string GetSha256Hash(string input)
        {
            using (var hashAlgorithm = new SHA256CryptoServiceProvider())
            {
                byte[] inputByte = Encoding.UTF8.GetBytes(input);
                byte[] hash = hashAlgorithm.ComputeHash(inputByte);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
