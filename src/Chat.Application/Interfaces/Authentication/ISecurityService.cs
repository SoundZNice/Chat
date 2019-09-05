using System;

namespace Chat.Application.Interfaces.Authentication
{
    public interface ISecurityService
    {
        // Create converted to base64
        // string hash which is stored in database
        string GetSha256Hash(string input);

        // Generate unique id for jwt id
        Guid CreateCryptographicallySecureGuid();
    }
}
