using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlayerService
    {
        Player GetById(int playerId);
        List<Player> GetAll();
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
        void DeleteById(int playerId);
    }
}
