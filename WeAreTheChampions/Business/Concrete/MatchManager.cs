using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Enums;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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


        [ValidationAspect(typeof(MatchValidator), ValidationStates.Add)]
        public IResult Add(Match match)
        {
            _matchDal.Add(match);
            return new SuccessResult();
        }

        public IResult Delete(Match match)
        {
            _matchDal.Delete(match);
            return new SuccessResult();
        }

        public IResult DeleteById(int matchId)
        {
            _matchDal.Delete(_matchDal.Get(m => m.Id == matchId));
            return new SuccessResult();
        }

        public IDataResult<List<Match>> GetAll()
        {

            return new SuccessDataResult<List<Match>>(_matchDal.GetAll());
        }

        public IDataResult<List<MatchesListDto>> GetAllWithAssociatedProperties()
        {
            return new SuccessDataResult<List<MatchesListDto>>(_matchDal.GetAllWithAssociatedProperties());
        }

        public IDataResult<List<MatchesListDto>> GetAllWithAssociatedPropertiesWithoutPlayed()
        {
            return new SuccessDataResult<List<MatchesListDto>>(_matchDal.GetAllWithAssociatedProperties(x => x.ResultId == null));

        }

        public IDataResult<Match> GetById(int matchId)
        {
            return new SuccessDataResult<Match>(_matchDal.Get(m => m.Id == matchId));
        }

        public IDataResult<Match> GetWithHomeAwayDetailsById(int matchId)
        {
            return new SuccessDataResult<Match>(_matchDal.GetWithHomeAwayDetailsByFilter(x => x.Id == matchId));
        }

        [ValidationAspect(typeof(MatchValidator), ValidationStates.Update)]
        public IResult Update(Match match)
        {
            _matchDal.Update(match);
            return new SuccessResult();
        }

    }
}
