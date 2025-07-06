using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobReferral.Domain.Entities;
using JobReferral.Domain.Interfaces;

namespace JobReferral.Infrastructure.Repositories;

public class MockReferrerRepository : IReferrerRepository
{
    private static readonly List<Referrer> _referrers = new()
    {
        new Referrer { Id = 1, Name = "Alice Smith", Company = "Acme Corp", Title = "Senior Engineer", Experience = 5, SuccessRate = 75 }
    };

    public Task<IEnumerable<Referrer>> SearchAsync(string query)
        => Task.FromResult<IEnumerable<Referrer>>(_referrers.Where(r => r.Name.Contains(query) || r.Company.Contains(query)));

    public Task<Referrer> GetByIdAsync(int id)
        => Task.FromResult(_referrers.First(r => r.Id == id));
}
