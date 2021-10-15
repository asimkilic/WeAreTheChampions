using Business.Abstract;
using Business.ValidationRules.FluentValidation;
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
        //TODO: ValidationAspect will add.
        //TODO: CacheAspect will add.

        private IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {

            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            
            ValidationTool.Validate(new ColorValidator(ValidationStates.Add),color);
            //TODO: Check if exist.
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            ValidationTool.Validate(new ColorValidator(ValidationStates.Delete), color);
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

        public void Update(Color color)
        {
            ValidationTool.Validate(new ColorValidator(ValidationStates.Update), color);
            _colorDal.Update(color);
        }
    }
}
