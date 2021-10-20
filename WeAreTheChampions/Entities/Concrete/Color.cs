using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public Color()
        {
            TeamColors = new HashSet<TeamColor>();
        }
        public int Id { get; set; }
        public string ColorName { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }


        public virtual ICollection<TeamColor> TeamColors { get; set; }
        public override string ToString() => ColorName;

    }
}
