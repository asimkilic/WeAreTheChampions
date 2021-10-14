using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TeamColorManager : ITeamColorService
    {
        private ITeamColorDal _teamColorDal;

        public TeamColorManager(ITeamColorDal teamColorDal)
        {
            _teamColorDal = teamColorDal;
        }

        public void Add(TeamColor teamColor)
        {
            _teamColorDal.Add(teamColor);
        }

        public void Delete(TeamColor teamColor)
        {
            _teamColorDal.Delete(teamColor);
        }

        public List<TeamColor> GetAll()
        {
            return _teamColorDal.GetAll();
        }

        public TeamColor GetByColorId(int colorId)
        {
            return _teamColorDal.Get(x => x.ColorId == colorId);
        }

        public TeamColor GetByTeamId(int teamId)
        {
            return _teamColorDal.Get(x => x.TeamId == teamId);
        }

        public void Update(TeamColor teamColor)
        {
            _teamColorDal.Update(teamColor);
        }
    }
}
