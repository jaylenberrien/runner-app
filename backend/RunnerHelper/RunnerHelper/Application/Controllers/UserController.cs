using Microsoft.AspNetCore.Mvc

namespace RunnerHelper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase()
    {
        private readonly ILogger<UserController> _logger;
        private readonly UserOrchestrator _userOrchestrator;

        public UserController(ILogger<UserController> logger, UserOrchestrator userOrchestrator)
        {
            _logger = logger;
            _userOrchestrator = userOrchestrator;
        }

        [HttpPost(Name = "Login")]
        public async Task<StatusCodeResult> Login(CreateAccountRequest)
        {

        }

        [HttpPost(Name = "CreateAccount")]
        public async Task<StatusCodeResult> CreateAccount(string username, string password)
        {

        }


    }
}
