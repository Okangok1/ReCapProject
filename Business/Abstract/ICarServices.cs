using Business.Utilities.Results;
using IEntities.Concrete;
using IEntities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarServices
    {

        //GetCarsByBrandId , GetCarsByColorId
       IDataResult<List<Car>> GetAll();

        IDataResult<List <Car>> GetCarsByBrandId(int Id);

       IDataResult <List<Car>> GetCarsByColorId(int ColorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();


         IResult Add(Car car);
       
        IResult Delete(Car car);
        IResult Update(Car car);

    }
}
