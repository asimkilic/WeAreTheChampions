using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Team : IEntity
    {
        public Team()
        {
            Players = new HashSet<Player>();
            TeamColors = new HashSet<TeamColor>();
            HomeMatches = new HashSet<Match>();
            AwayMatches = new HashSet<Match>();

        }
        public int Id { get; set; }
        public string TeamName { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<TeamColor> TeamColors { get; set; }
        public virtual ICollection<Match> HomeMatches { get; set; }
        public virtual ICollection<Match> AwayMatches { get; set; }


        public override string ToString() => TeamName;


    }
}
