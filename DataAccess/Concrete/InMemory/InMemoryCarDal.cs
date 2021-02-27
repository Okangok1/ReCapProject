using DataAccess.Abstract;
using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
       
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColorId=2,DailyPrice=98000,ModelYear="1982",Description="Aile için"},
                new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=50000,ModelYear="1972",Description="Aile için"},
                new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=198000,ModelYear="2019",Description="Spor için"},
                new Car{Id=4,BrandId=1,ColorId=4,DailyPrice=100000,ModelYear="2005",Description="Seyahat için"},
                new Car{Id=5,BrandId=4,ColorId=4,DailyPrice=88000,ModelYear="2005",Description="Seyahat için"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            
            Car carToDelete = _cars.SingleOrDefault(p=> p.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id ==Id ).ToList();
        }

        public void Update(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToDelete.ModelYear = car.ModelYear;
            carToDelete.BrandId = car.BrandId;
            carToDelete.ColorId = car.ColorId;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.Description = car.Description;
        }
    }
}
