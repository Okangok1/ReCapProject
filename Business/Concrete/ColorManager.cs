using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results;
using DataAccess.Abstract;
using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorServices
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            if (color.Name.Length<2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);
            }
            _colorDal.Add(color);
           return new SuccessResult (Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            int colorId = color.Id;
            if (color.Id !=colorId)
            {
                return new ErrorResult(Messages.ColorDeletedfailed);
            }
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>> (_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color> (_colorDal.Get(c => c.Id == colorId));

        }

        public IResult Update(Color color)
        {
            string colorName = color.Name;
            if (color.Name.Length<2 && color.Name != colorName)
            {
                return new SuccessResult(Messages.ColorUpdatedFailed);
            }
            _colorDal.Update(color);
            return new ErrorResult(Messages.ColorUpdated);
        }
    }
}
