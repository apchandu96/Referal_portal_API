using JobReferral.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobReferral.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _auth;

    public AuthController(IAuthService auth) => _auth = auth;

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest req)
        => Ok(new { message = await _auth.LoginAsync(req.Email, req.Password) });

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest req)
        => Ok(new { message = await _auth.RegisterAsync(req.Name, req.Email, req.Password, req.Linkedin) });
}

public record LoginRequest(string Email, string Password);
public record RegisterRequest(string Name, string Email, string Password, string Linkedin);
