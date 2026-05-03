public class UserOrchestrator
{
    private readonly T context;
    private readonly ILogger<UserOrchestrator> _logger;

    public UserOrchestrator(ILogger<UserOrchestrator> logger)
    {
        _logger = logger;
    }

    public async Task<bool> ValidateUser()
    {

    }

    public async Task<StatusCodeResult> Login(string username, string password)
    {

    }

    public async Task<StatusCodeResult> CreateAccount(string username, string password)
    {

    }

    public async Task<StatusCodeResult> Logout()
    {

    }