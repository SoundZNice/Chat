using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Chat.Application.Account.LoginUserCommand
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginCommandResult>
    {
        public async Task<LoginCommandResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
