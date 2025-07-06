using System.Collections.Generic;
using System.Threading.Tasks;
using JobReferral.Domain.Entities;
using JobReferral.Domain.Interfaces;

namespace JobReferral.Infrastructure.Repositories;

public class MockReferralRequestRepository : IReferralRequestRepository
{
    public Task<IEnumerable<ReferralRequest>> GetReferralRequestsAsync()
    {
        var list = new List<ReferralRequest>
        {
            new ReferralRequest { Id = 1, Title = "Frontend Developer at Acme Corp", Status = "Under review" }
        };
        return Task.FromResult<IEnumerable<ReferralRequest>>(list);
    }
}
