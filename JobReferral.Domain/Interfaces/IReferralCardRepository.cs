using JobReferral.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobReferral.Domain.Interfaces
{
    public interface IReferralCardRepository
    {
        /// <summary>
        /// Landing / “latest referrals” feed
        /// </summary>
        Task<IEnumerable<ReferralCard>> GetLandingCardsAsync();

        /// <summary>
        /// Search by company, role, name, etc.
        /// </summary>
        Task<IEnumerable<ReferralCard>> SearchCardsAsync(string query);
    }
}
