using MediatR;

namespace Chat.Application.Account.LoginUserCommand
{
    public class LoginCommand : IRequest<LoginCommandResult>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
