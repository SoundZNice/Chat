namespace Chat.Application.Interfaces.Authentication
{
    public interface ISecurityService
    {
        string GetSha256Hash(string input);
    }
}
