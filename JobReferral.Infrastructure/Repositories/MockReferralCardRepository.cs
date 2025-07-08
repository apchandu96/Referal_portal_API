using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobReferral.Domain.Entities;
using JobReferral.Domain.Interfaces;

namespace JobReferral.Infrastructure.Repositories;
public class MockReferralCardRepository : IReferralCardRepository
{
    private static readonly List<ReferralCard> _all = new()
    {
        new ReferralCard {
            Id = 1,
            Title = "Frontend Developer",
            Company = "Acme Corp",
            Snippet = "Seeking React/Vite expert for our web team.",
            ImageUrl = "https://via.placeholder.com/300x200",
            SuccessRate = 78
        },
        new ReferralCard {
            Id = 2,
            Title = "Backend Engineer",
            Company = "Globex Inc",
            Snippet = "Looking for a .NET Core specialist.",
            ImageUrl = "https://via.placeholder.com/300x200",
            SuccessRate = 82
        },
        new ReferralCard {
            Id = 3,
            Title = "Full-Stack Developer",
            Company = "Initech",
            Snippet = "End-to-end JavaScript experience desired.",
            ImageUrl = "https://via.placeholder.com/300x200",
            SuccessRate = 90
        }
    };

    public Task<IEnumerable<ReferralCard>> GetLandingCardsAsync()
        => Task.FromResult<IEnumerable<ReferralCard>>(_all);

    public Task<IEnumerable<ReferralCard>> SearchCardsAsync(string query)
    {
        var results = _all
            .Where(r => r.Title.Contains(query, System.StringComparison.OrdinalIgnoreCase)
                     || r.Company.Contains(query, System.StringComparison.OrdinalIgnoreCase));
        return Task.FromResult<IEnumerable<ReferralCard>>(results);
    }
}
