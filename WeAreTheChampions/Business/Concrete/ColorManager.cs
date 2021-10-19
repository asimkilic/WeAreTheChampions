using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Enums;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {

        private IColorDal _colorDal;
        private ITeamColorService _teamColorService;
        public ColorManager(IColorDal colorDal, ITeamColorService teamColorService)
        {
            // !! If you make an injection, inject it's service not manager class.
            _colorDal = colorDal;
            _teamColorService = teamColorService;
        }
        // admin        : has authority over the whole project
        // color.admin  : has authority over the Color operations
        // color.add    : has authority only add operation
        [SecuredOperation("admin,color.admin,color.add")]
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {

            //TODO: Check if exist.

            var result = BusinessRules.Run(CheckIfColorExist(color), CheckIfColorNameExist(color.ColorName));
            if (result != null)
            {
                return result;

            }
            _colorDal.Add(color);

            return new SuccessResult();
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Color color)
        {
            Add(color);
            if (color.ColorName.Contains("yeşil"))
            {
                throw new Exception();
            }
            Add(color);
            return null;
        }

        [ValidationAspect(typeof(ColorValidator), ValidationStates.Delete)]
        public IResult Delete(Color color)
        {

            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public IResult DeleteById(int colorId)
        {
            // It uses Delete method thus it doesnt need to validation
            _colorDal.Delete(_colorDal.Get(c => c.Id == colorId));
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == colorId));
        }



        [ValidationAspect(typeof(ColorValidator), ValidationStates.Update)]
        public IResult Update(Color color)
        {

            _colorDal.Update(color);
            return new SuccessResult();
        }


        // Business Rules
        private IResult CheckIfColorExist(Color color)
        {
            var result = _colorDal.GetAll(x => x.Red == color.Red && x.Green == color.Green && x.Blue == color.Blue).Count == 0;  //TODO: Create a method which checc RGB  exist in DB 
            if (!result)
            {
                return new ErrorResult("Bu renk zaten mevcut.");
            }
            return new SuccessResult();
        }

        private IResult CheckIfColorNameExist(string colorName)
        {
            var result = _colorDal.GetAll(x => x.ColorName.ToLower() == colorName.ToLower()).Count == 0; //TODO: create a method which checks name exist in DB
            if (!result)
            {
                return new ErrorResult("Aynı isimden en fazla 1 adet Renk eklenebilir");
            }
            return new SuccessResult();
        }
    }
}
