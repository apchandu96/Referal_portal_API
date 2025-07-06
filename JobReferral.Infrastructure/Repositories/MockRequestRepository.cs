using System.Threading.Tasks;
using JobReferral.Domain.Interfaces;

namespace JobReferral.Infrastructure.Repositories;

public class MockRequestRepository : IRequestRepository
{
    public Task SubmitRequestAsync(int referrerId, string message, string timeline)
        => Task.CompletedTask;
}
