using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class TeamColorDto : IDto
    {
        public int TeamColorId { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

    }
}
