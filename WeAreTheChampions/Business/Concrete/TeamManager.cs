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
    public class TeamManager : ITeamService
    {
        private ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void Add(Team team)
        {
            _teamDal.Add(team);
        }

        public void Delete(Team team)
        {
            _teamDal.Delete(team);
        }

        public void DeleteById(int teamId)
        {
            _teamDal.Delete(_teamDal.Get(t => t.Id == teamId));
        }

        public List<Team> GetAll()
        {
            return _teamDal.GetAll();
        }

        public Team GetById(int teamId)
        {
            return _teamDal.Get(t => t.Id == teamId);
        }

        public void Update(Team team)
        {
            _teamDal.Update(team);
        }
    }
}
