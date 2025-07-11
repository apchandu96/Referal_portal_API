﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobReferral.Domain.Entities
{
    public class ReferralCard
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string? Snippet { get; set; }
        public string? ImageUrl { get; set; }
        public int? SuccessRate { get; set; }
    }
}
