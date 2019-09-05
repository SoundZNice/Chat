namespace Chat.Application.Interfaces.Auth
{
    public interface ISecurityService
    {
        string GetSha256Hash(string input);
    }
}
