using JobReferral.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobReferral.Domain.Interfaces;

public interface IReferrerRepository
{
    Task<IEnumerable<Referrer>> SearchAsync(string query);
    Task<Referrer> GetByIdAsync(int id);
}
