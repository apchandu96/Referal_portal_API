using JobReferral.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobReferral.Application.Services;

public interface IReferralService
{
    Task<IEnumerable<ReferralRequest>> GetDashboardAsync();
    Task<IEnumerable<Referrer>> SearchReferrersAsync(string query);
    Task<Profile> GetProfileAsync();
    Task<Referrer> GetReferrerAsync(int id);
    Task SubmitRequestAsync(int referrerId, string message, string timeline);
}
