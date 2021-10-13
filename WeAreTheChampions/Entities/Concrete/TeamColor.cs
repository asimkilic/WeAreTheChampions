using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class TeamColor : IEntity
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
}
