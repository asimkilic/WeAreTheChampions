using Business.Abstract;
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
    public class TeamColorManager : ITeamColorService
    {
        private ITeamColorDal _teamColorDal;

        public TeamColorManager(ITeamColorDal teamColorDal)
        {
            _teamColorDal = teamColorDal;
        }

        public IResult Add(TeamColor teamColor)
        {
            var result = BusinessRules.Run(CheckColorExistInTeam(teamColor));
            if (result != null)
            {
                return result;

            }
            _teamColorDal.Add(teamColor);
            return new SuccessResult();
        }

        public IResult DeleteByColorIdTeamId(int colorId, int teamId)
        {
            var teamColor = _teamColorDal.Get(x => x.ColorId == colorId && x.TeamId == teamId);
            Delete(teamColor);
            return new SuccessResult();
        }
        public IResult Delete(TeamColor teamColor)
        {
            _teamColorDal.Delete(teamColor);
            return new SuccessResult();

        }

        public IDataResult<List<TeamColor>> GetAll()
        {
            return new SuccessDataResult<List<TeamColor>>(_teamColorDal.GetAll());
        }

        public IDataResult<List<TeamColorDto>> GetAllDetailsWithAssociatedProperties()
        {
            return new SuccessDataResult<List<TeamColorDto>>(_teamColorDal.GetAllDetailsWithAssociatedProperties());
        }
        public IDataResult<List<TeamColorDto>> GetAllDetailsWithAssociatedPropertiesByTeamId(int teamId)
        {
            return new SuccessDataResult<List<TeamColorDto>>(_teamColorDal.GetAllDetailsWithAssociatedProperties(x => x.TeamId == teamId));
        }
        public IDataResult<List<TeamColorDto>> GetAllDetailsWithAssociatedPropertiesByColorId(int colorId)
        {
            return new SuccessDataResult<List<TeamColorDto>>(_teamColorDal.GetAllDetailsWithAssociatedProperties(x => x.ColorId == colorId));
        }

        public IDataResult<List<TeamColor>> GetByColorId(int colorId)
        {
            return new SuccessDataResult<List<TeamColor>>(_teamColorDal.GetAll(x => x.ColorId == colorId));
        }

        public IDataResult<List<TeamColor>> GetByTeamId(int teamId)
        {
            return new SuccessDataResult<List<TeamColor>>(_teamColorDal.GetAll(x => x.TeamId == teamId));
        }

        public IResult Update(TeamColor teamColor)
        {

            var result = BusinessRules.Run(CheckColorExistInTeam(teamColor));
            if (result != null)
            {
                return result;

            }
            _teamColorDal.Update(teamColor);
            return new SuccessResult();

        }

        private IResult CheckColorExistInTeam(TeamColor teamColor)
        {
            var result = _teamColorDal.GetAll(x => x.ColorId == teamColor.ColorId && x.TeamId == teamColor.TeamId).Count == 0;
            if (!result)
            {
                return new ErrorResult("Renk zaten takımda mevcut");
            }
            return new SuccessResult();
        }

        public IResult DeleteByColorId(int colorId)
        {
            var deletedItems = _teamColorDal.GetAll(x => x.ColorId == colorId);
            foreach (var color in deletedItems)
            {
                _teamColorDal.Delete(color);
            }
            return new SuccessResult();
        }
    }
}
