namespace JobReferral.Application.Services;

using System.Threading.Tasks;

public interface IAuthService
{
    Task<string> LoginAsync(string email, string password);
    Task<string> RegisterAsync(string name, string email, string password, string linkedin);
}
