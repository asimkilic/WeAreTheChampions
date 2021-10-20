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
    public class PlayerManager : IPlayerService
    {
        private IPlayerDal _playerDal;

        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }

        public IResult Add(Player player)
        {
            _playerDal.Add(player);
            return new SuccessResult();
        }

        public IResult Delete(Player player)
        {
            _playerDal.Delete(player);
            return new SuccessResult();

        }

        public IResult DeleteById(int playerId)
        {
            return Delete(_playerDal.Get(p => p.Id == playerId));

        }

        public IDataResult<List<Player>> GetAll()
        {
            return new SuccessDataResult<List<Player>>(_playerDal.GetAll());
        }

        public IDataResult<List<Player>> GetAllPlayersWithAssociatedProperties()
        {
            return new SuccessDataResult<List<Player>>(_playerDal.GetAllPlayersWithAssociatedProperties());
        }

        public IDataResult<Player> GetById(int playerId)
        {
            return new SuccessDataResult<Player>(_playerDal.Get(p => p.Id == playerId));
        }

        public IDataResult<List<Player>> GetPlayersByTeamId(int teamId)
        {
            return new SuccessDataResult<List<Player>>(_playerDal.GetAll(x => x.TeamId == teamId));
        }

        public IResult Update(Player player)
        {
            _playerDal.Update(player);
            return new SuccessResult();

        }
    }
}
