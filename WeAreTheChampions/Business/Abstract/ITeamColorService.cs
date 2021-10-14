using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeamColorService
    {
        TeamColor GetByTeamId(int teamId);
        TeamColor GetByColorId(int colorId);
        List<TeamColor> GetAll();
        void Add(TeamColor teamColor);
        void Update(TeamColor teamColor);
        void Delete(TeamColor teamColor);
        
    }
}
