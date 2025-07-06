using System.Threading.Tasks;
using JobReferral.Application.Services;

namespace JobReferral.Application.Services;

public class AuthService : IAuthService
{
    public Task<string> LoginAsync(string email, string password)
        => Task.FromResult("mock login response");

    public Task<string> RegisterAsync(string name, string email, string password, string linkedin)
        => Task.FromResult("Registration successful");
}
