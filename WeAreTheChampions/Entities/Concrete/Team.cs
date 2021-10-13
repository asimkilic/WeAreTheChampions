using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Team:IEntity
    {
        public int Id { get; set; }
        public string TeamName { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
    }
}
