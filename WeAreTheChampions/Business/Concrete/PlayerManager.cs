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
    public class PlayerManager : IPlayerService
    {
        private IPlayerDal _playerDal;

        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }

        public void Add(Player player)
        {
            _playerDal.Add(player);
        }

        public void Delete(Player player)
        {
            _playerDal.Delete(player);
        }

        public void DeleteById(int playerId)
        {
            _playerDal.Delete(_playerDal.Get(p => p.Id == playerId));
        }

        public List<Player> GetAll()
        {
            return _playerDal.GetAll();
        }

        public Player GetById(int playerId)
        {
            return _playerDal.Get(p => p.Id == playerId);
        }

        public void Update(Player player)
        {
            _playerDal.Update(player);
        }
    }
}
