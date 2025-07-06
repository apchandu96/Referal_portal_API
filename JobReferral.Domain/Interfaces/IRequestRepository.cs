using System.Threading.Tasks;

namespace JobReferral.Domain.Interfaces;

public interface IRequestRepository
{
    Task SubmitRequestAsync(int referrerId, string message, string timeline);
}
