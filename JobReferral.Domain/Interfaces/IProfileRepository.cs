using JobReferral.Domain.Entities;
using System.Threading.Tasks;

namespace JobReferral.Domain.Interfaces;

public interface IProfileRepository
{
    Task<Profile> GetProfileAsync();
}
