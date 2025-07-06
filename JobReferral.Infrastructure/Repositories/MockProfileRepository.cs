using System.Threading.Tasks;
using JobReferral.Domain.Entities;
using JobReferral.Domain.Interfaces;

namespace JobReferral.Infrastructure.Repositories;

public class MockProfileRepository : IProfileRepository
{
    public Task<Profile> GetProfileAsync()
        => Task.FromResult(new Profile
        {
            Name = "Test User",
            Email = "test@example.com",
            ProfileComplete = 85
        });
}
