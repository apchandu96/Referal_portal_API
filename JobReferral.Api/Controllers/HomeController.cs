using Microsoft.AspNetCore.Mvc;
using JobReferral.Application.Services;

namespace JobReferral.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class HomeController : ControllerBase
{
    private readonly IHomeService _home;

    public HomeController(IHomeService home) => _home = home;

    /// <summary>
    /// GET /api/v1/home
    /// GET /api/v1/home?query=react
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] string? query = null)
    {
        var cards = await _home.GetCardsAsync(query);
        return Ok(new { referrals = cards });
    }
}
