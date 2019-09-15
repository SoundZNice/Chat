namespace Chat.Application.Account.LoginUserCommand
{
    public class LoginCommandResult
    {
        public bool Succeeded { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
