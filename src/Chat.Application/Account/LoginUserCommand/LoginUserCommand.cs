using MediatR;

namespace Chat.Application.Account.LoginUserCommand
{
    public class LoginUserCommand : IRequest<LoginUserViewModel>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}