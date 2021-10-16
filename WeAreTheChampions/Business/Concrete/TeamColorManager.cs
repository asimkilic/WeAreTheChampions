using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(TeamColor teamColor)
        {
            _teamColorDal.Add(teamColor);
            return new SuccessResult();
        }

        public IResult Delete(TeamColor teamColor)
        {
            _teamColorDal.Delete(teamColor);
            return new SuccessResult();

        }

        public IDataResult<List<TeamColor>> GetAll()
        {
            return new SuccessDataResult<List<TeamColor>>(_teamColorDal.GetAll());
        }

        public IDataResult<TeamColor> GetByColorId(int colorId)
        {
            return new SuccessDataResult<TeamColor>(_teamColorDal.Get(x => x.ColorId == colorId));
        }

        public IDataResult<TeamColor> GetByTeamId(int teamId)
        {
            return new SuccessDataResult<TeamColor>(_teamColorDal.Get(x => x.TeamId == teamId));
        }

        public IResult Update(TeamColor teamColor)
        {
            _teamColorDal.Update(teamColor);
            return new SuccessResult();

        }
    }
}
