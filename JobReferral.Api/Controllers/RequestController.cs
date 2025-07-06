using JobReferral.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobReferral.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class RequestController : ControllerBase
{
    private readonly IReferralService _svc;

    public RequestController(IReferralService svc) => _svc = svc;

    [HttpPost("{id:int}")]
    public async Task<IActionResult> Post(int id, RequestDto dto)
    {
        await _svc.SubmitRequestAsync(id, dto.Message, dto.Timeline);
        return Ok(new { message = "Referral request submitted successfully", id });
    }
}

public record RequestDto(string Message, string Timeline);
