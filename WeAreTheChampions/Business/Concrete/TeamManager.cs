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
    public class TeamManager : ITeamService
    {
        private ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public IResult Add(Team team)
        {
            _teamDal.Add(team);
            return new SuccessResult();
        }

        public IResult Delete(Team team)
        {
            _teamDal.Delete(team);
            return new SuccessResult();

        }

        public IResult DeleteById(int teamId)
        {
            return Delete(_teamDal.Get(t => t.Id == teamId));
        }

        public IDataResult<List<Team>> GetAll()
        {
            return new SuccessDataResult<List<Team>>(_teamDal.GetAll());
        }

        public IDataResult<Team> GetById(int teamId)
        {
            return new SuccessDataResult<Team>(_teamDal.Get(t => t.Id == teamId));
        }

        public IResult Update(Team team)
        {
            _teamDal.Update(team);
            return new SuccessResult();

        }
    }
}
