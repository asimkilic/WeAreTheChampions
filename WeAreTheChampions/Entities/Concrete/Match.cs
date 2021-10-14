using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;


namespace Entities.Concrete
{
    public class Match:IEntity
    {
        public int Id { get; set; }
        public DateTime MatchTime { get; set; }
        public byte? Score1 { get; set; }
        public byte? Score2 { get; set; }
        public ResultEnum? ResultId { get; set; }

        public int HomeTeamId { get; set; }
        public virtual Team HomeTeam { get; set; }
        public int AwayTeamId { get; set; }
        public virtual Team AwayTeam { get; set; }

     
    }
}
