using JobReferral.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobReferral.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ProfileController : ControllerBase
{
    private readonly IReferralService _svc;

    public ProfileController(IReferralService svc) => _svc = svc;

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(new { profile = await _svc.GetProfileAsync() });
}
