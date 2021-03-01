using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results;
using DataAccess.Abstract;
using IEntities.Concrete;
using IEntities.DTOs;
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

        public IResult Add(Car car)
        {
            if (car.Description.Length<2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
                _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
            
        }

        public IResult Delete(Car car)
        {
            if (car.Id !=car.Id)
            {
                //deletion failed
                return new ErrorResult(Messages.CarDeletionFailed);
            }
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);

        }
    

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            //  return new DataResult<List<Product>> (_productDal.GetAll(),true,Messages.ProductsListed);
            return new DataResult<List<Car>>(_carDal.GetAll(),true, Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int   brandId)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(c => c.BrandId == brandId));

        }


        public IDataResult<List<Car>>  GetCarsByColorId(int ColorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == ColorId));
        }

        public IResult Update(Car car)
        {
            string CarName = car.Description;
            if (car.Description.Length < 2 &&car.Description != CarName )
            {
                return new ErrorResult(Messages.CarNameInvalidUpdate);
            }
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);

        }
    }
}
