using Business.Abstract;
using DataAccess.Abstract;
using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CarManager : ICarServices
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.Description.Length>2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine(car.Description);
            }
            else
            {
                Console.WriteLine(" araba ismi minimun 2 karakterrden oluşmak zorundadır.");
                Console.WriteLine();
                Console.WriteLine("Günlük fiyatı 0 eşit veya altında olamaz. lütfen bu kurallara göre ekleme işlemini yapınız.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();   
        }

        public List<Car> GetCarsByBrandId(int   brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);

        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            return _carDal.GetAll(c => c.ColorId == ColorId);
        }
    }
}
