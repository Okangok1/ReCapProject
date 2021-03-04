using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results;
using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerServices
    {
        public IResult Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetById(int id)
        {
           return new SuccessDataResult
        }

        public IResult Update(Customer customer)
        {
            string customerCompany = customer.CompanyName;
            if (customer.CompanyName.Length<4 && customer.CompanyName != customerCompany)
            {
                return new ErrorResult(Messages.CustemerCompanyNameInvalid);
            }
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
