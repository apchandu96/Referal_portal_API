using JobReferral.Domain.Entities;
using JobReferral.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobReferral.Application.Services
{
    public class HomeService : IHomeService
    {
        private readonly IReferralCardRepository _repo;

        public HomeService(IReferralCardRepository repo)
            => _repo = repo;

        public Task<IEnumerable<ReferralCard>> GetCardsAsync(string? query = null)
            => string.IsNullOrWhiteSpace(query)
                ? _repo.GetLandingCardsAsync()
                : _repo.SearchCardsAsync(query!);
    }
}
