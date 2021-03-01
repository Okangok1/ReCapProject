using Business.Utilities.Results;
using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorServices
    {
        IDataResult<List<Color>> GetAll();
       IDataResult<Color> GetById(int colorId);

        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
    }
}
