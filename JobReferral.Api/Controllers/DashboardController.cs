using JobReferral.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobReferral.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class DashboardController : ControllerBase
{
    private readonly IReferralService _svc;

    public DashboardController(IReferralService svc) => _svc = svc;

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(new { referrals = await _svc.GetDashboardAsync() });
}
