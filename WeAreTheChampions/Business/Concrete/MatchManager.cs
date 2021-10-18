using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Enums;
using Core.Utilities.Business;
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
        private ITeamService _teamService;  // inject service not manager

        public MatchManager(IMatchDal matchDal, ITeamService teamService)
        {
            _matchDal = matchDal;
            _teamService = teamService;
        }

        [SecuredOperation("admin,match.admin,match.add", Priority = 1)]
        [ValidationAspect(typeof(MatchValidator), ValidationStates.Add)]
        public IResult Add(Match match)
        {
            _matchDal.Add(match);
            return new SuccessResult();
        }
        [SecuredOperation("admin,match.admin,match.delete", Priority = 1)]
        public IResult Delete(Match match)
        {
            _matchDal.Delete(match);
            return new SuccessResult();
        }
        [SecuredOperation("admin,match.admin,match.delete", Priority = 1)]
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

        [SecuredOperation("admin,match.admin,match.update")]
        [ValidationAspect(typeof(MatchValidator), ValidationStates.Update)]
        public IResult Update(Match match)
        {
            var result = BusinessRules.Run(CheckScores(ref match), CheckDate(match));
            if (result != null)
                return result;

            _matchDal.Update(match);
            return new SuccessResult();
        }

        //  ###    Business Rules ###

        private IResult CheckScores(ref Match match)
        {
            if ((match.Score1 != null && match.Score2 == null) || (match.Score2 != null && match.Score1 == null))
            {
                return new ErrorResult("Maç skorları hatalı.");
            }
            if (match.Score1 != null && match.Score2 != null)
            {
                match.ResultId = match.Score1 > match.Score2 ? ResultEnum.Team1Won : (match.Score1 == match.Score2 ? ResultEnum.Draw : ResultEnum.Team2Won);
            }
            return new SuccessResult();

        }

        private IResult CheckDate(Match match)
        {

            var result1 = _matchDal.GetAll(x => x.Id != match.Id && (x.HomeTeamId == match.HomeTeamId || x.AwayTeamId == match.HomeTeamId) && x.MatchTime == match.MatchTime).Count == 0;
            var result2 = _matchDal.GetAll(x => x.Id != match.Id && (x.AwayTeamId == match.AwayTeamId || x.HomeTeamId == match.AwayTeamId) && x.MatchTime == match.MatchTime).Count == 0;


            if (result1 && result2)
            {
                return new SuccessResult();
            }

            return new ErrorResult("Seçilen tarihte zaten bir maç tanımlı."); ;
        }
    }
}
