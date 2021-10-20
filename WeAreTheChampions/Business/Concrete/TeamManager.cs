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
        private IPlayerService _playerService;

        public TeamManager(ITeamDal teamDal, IPlayerService playerService)
        {
            _teamDal = teamDal;
            _playerService = playerService;
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

        public IResult DeleteTeamAndSetPlayerTeamsNull(int teamId)
        {
            var deletedPlayers = _playerService.GetPlayersByTeamId(teamId).Data;
            foreach (var player in deletedPlayers)
            {
                player.TeamId = null;
                player.Team = null;
                _playerService.Update(player);
            }
            _teamDal.Delete(_teamDal.Get(x => x.Id == teamId));
            return new SuccessResult();
        }

        public IDataResult<List<Team>> GetAll()
        {
            return new SuccessDataResult<List<Team>>(_teamDal.GetAll());
        }

        public IDataResult<Team> GetById(int teamId)
        {
            return new SuccessDataResult<Team>(_teamDal.Get(t => t.Id == teamId));
        }

        public IDataResult<Team> GetTeamByName(string teamName)
        {
            return new SuccessDataResult<Team>(_teamDal.Get(t => t.TeamName.ToLower() == teamName.ToLower()));
        }

        public IResult Update(Team team)
        {
            _teamDal.Update(team);
            return new SuccessResult();

        }
    }
}
