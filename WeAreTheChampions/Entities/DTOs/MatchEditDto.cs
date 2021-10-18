using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MatchEditDto : IDto
    {
        public int MatchId { get; set; }
        public byte? HomeScore { get; set; }
        public byte? AwayScore { get; set; }
        public DateTime MatchTime { get; set; }

    }
}
