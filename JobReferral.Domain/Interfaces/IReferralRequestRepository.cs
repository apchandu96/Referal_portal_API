using JobReferral.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobReferral.Domain.Interfaces;

public interface IReferralRequestRepository
{
    Task<IEnumerable<ReferralRequest>> GetReferralRequestsAsync();
}
