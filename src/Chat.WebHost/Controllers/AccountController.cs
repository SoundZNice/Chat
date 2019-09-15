using Chat.Application.Account.LoginUserCommand;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Chat.WebHost.Controllers
{
    [Produces("application/json")]
    [Route("api/account")]
    public class AccountController : BaseController
    {
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]LoginCommand command)
        {
            System.Console.WriteLine();
            //TODO: Add fluent Validator
            return Ok();
        }
    }
}
