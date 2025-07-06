using JobReferral.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobReferral.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class SearchController : ControllerBase
{
    private readonly IReferralService _svc;

    public SearchController(IReferralService svc) => _svc = svc;

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery]string query)
        => Ok(new { results = await _svc.SearchReferrersAsync(query) });
}
