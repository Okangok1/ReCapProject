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
    public class BrandManager : IBrandServices
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.Name.Length<3)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            _brandDal.Add(brand);
           return new SuccessResult (Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            if (brand.Id !=brand.Id)
            {
                return new ErrorResult(Messages.BrandDeletedFailed);
            }
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>  (_brandDal.GetAll());
        }

        public IDataResult<List<Brand>> GetById(int brandId)
        {
           return new SuccessDataResult<List<Brand>> (_brandDal.GetAll(b => b.Id == brandId));
        }

        public IResult Update(Brand brand)
        {
            string brandName = brand.Name;
            if (brand.Name.Length<3 &&brand.Name != brandName)
            {
                return new ErrorResult(Messages.BrandUpdatedFailed);
            }
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
