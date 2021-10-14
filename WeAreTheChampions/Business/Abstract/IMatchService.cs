using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IMatchService
    {
        Match GetById(int matchId);
        List<Match> GetAll();
        void Add(Match match);
        void Update(Match match);
        void Delete(Match match);
        void DeleteById(int matchId);
    }
}
