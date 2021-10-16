using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Enums;
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

        //TODO: CacheAspect will add.

        private IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {

            _colorDal = colorDal;
        }

        [ValidationAspect(typeof(ColorValidator))]
        public void Add(Color color)
        {

            //TODO: Check if exist.
            //TODO: return type can change with boolean
            if (!CheckIfColorExist(color))
            {
                _colorDal.Add(color);
            }
        }

        [ValidationAspect(typeof(ColorValidator), ValidationStates.Delete)]
        public void Delete(Color color)
        {

            _colorDal.Delete(color);
        }

        public void DeleteById(int colorId)
        {
            // It uses Delete method thus it doesnt need to validation
            _colorDal.Delete(_colorDal.Get(c => c.Id == colorId));
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(c => c.Id == colorId);
        }

        [ValidationAspect(typeof(ColorValidator), ValidationStates.Update)]
        public void Update(Color color)
        {

            _colorDal.Update(color);
        }


        // Business Rules
        private bool CheckIfColorExist(Color color)
        {
            var result = false;  //TODO: Create a method which checck RGB and ColorName exist in DB 
            if (result)
            {
                throw new Exception("Color already exist in database");
            }
            return result;
        }
    }
}
