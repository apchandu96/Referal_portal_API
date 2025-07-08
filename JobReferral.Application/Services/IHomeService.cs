using JobReferral.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobReferral.Application.Services
{
    public interface IHomeService
    {
        /// <summary>
        /// If query is null or empty, returns landing cards; otherwise returns search results.
        /// </summary>
        Task<IEnumerable<ReferralCard>> GetCardsAsync(string? query = null);
    }
}
