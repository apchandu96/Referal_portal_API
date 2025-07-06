using System.Collections.Generic;
using System.Threading.Tasks;
using JobReferral.Domain.Entities;
using JobReferral.Domain.Interfaces;

namespace JobReferral.Application.Services;

public class ReferralService : IReferralService
{
    private readonly IProfileRepository _profileRepo;
    private readonly IReferralRequestRepository _requestRepo;
    private readonly IReferrerRepository _referrerRepo;
    private readonly IRequestRepository _submitRepo;

    public ReferralService(
        IProfileRepository profileRepo,
        IReferralRequestRepository requestRepo,
        IReferrerRepository referrerRepo,
        IRequestRepository submitRepo)
    {
        _profileRepo = profileRepo;
        _requestRepo = requestRepo;
        _referrerRepo = referrerRepo;
        _submitRepo = submitRepo;
    }

    public Task<IEnumerable<ReferralRequest>> GetDashboardAsync()
        => _requestRepo.GetReferralRequestsAsync();

    public Task<IEnumerable<Referrer>> SearchReferrersAsync(string query)
        => _referrerRepo.SearchAsync(query);

    public Task<Profile> GetProfileAsync()
        => _profileRepo.GetProfileAsync();

    public Task<Referrer> GetReferrerAsync(int id)
        => _referrerRepo.GetByIdAsync(id);

    public Task SubmitRequestAsync(int referrerId, string message, string timeline)
        => _submitRepo.SubmitRequestAsync(referrerId, message, timeline);
}
