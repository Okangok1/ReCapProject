using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarServices
    {

        //GetCarsByBrandId , GetCarsByColorId
        List<Car> GetAll();

        List<Car> GetCarsByBrandId(int Id);

        List<Car> GetCarsByColorId(int ColorId);

         void Add(Car car);

    }
}
