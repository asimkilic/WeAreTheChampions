using Business.Abstract;
using Business.ValidationRules.FluentValidation;
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
            var context = new ValidationContext<Color>(color);
            ColorValidator colorValidator = new ColorValidator();
            var result = colorValidator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            //TODO: Check if exist.
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public void DeleteById(int colorId)
        {
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
            _colorDal.Update(color);
        }
    }
}
