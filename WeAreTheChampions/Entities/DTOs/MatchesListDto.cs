using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MatchesListDto : IDto
    {
        public int MatchId { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime MatchTime { get; set; }
        public string DateText => $"{MatchTime.ToShortDateString()}";
        public string HourText => $"{MatchTime.ToString("HH:mm")}";
        public string ResultText => $"{WriteScores()}";

        private string WriteScores()
        {
            return (ScoreHome == null ? "?" : ScoreHome.ToString()) + " - " + (ScoreAway == null ? "?" : ScoreAway.ToString());

        }

        public byte? ScoreHome { get; set; }
        public byte? ScoreAway { get; set; }



    }
}
