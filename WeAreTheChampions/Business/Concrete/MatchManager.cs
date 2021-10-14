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
    public class MatchManager : IMatchService
    {
        private IMatchDal _matchDal;

        public MatchManager(IMatchDal matchDal)
        {
            _matchDal = matchDal;
        }

        public void Add(Match match)
        {
            _matchDal.Add(match);
        }

        public void Delete(Match match)
        {
            _matchDal.Delete(match);
        }

        public void DeleteById(int matchId)
        {
            _matchDal.Delete(_matchDal.Get(m => m.Id == matchId));
        }

        public List<Match> GetAll()
        {
            return _matchDal.GetAll();
        }

        public Match GetById(int matchId)
        {
            return _matchDal.Get(m => m.Id == matchId);
        }

        public void Update(Match match)
        {
            _matchDal.Update(match);
        }
    }
}
