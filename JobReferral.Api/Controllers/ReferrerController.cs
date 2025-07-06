using JobReferral.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobReferral.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ReferrerController : ControllerBase
{
    private readonly IReferralService _svc;

    public ReferrerController(IReferralService svc) => _svc = svc;

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
        => Ok(await _svc.GetReferrerAsync(id));
}
