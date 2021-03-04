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
    public class CustomerManager : ICustomerServices
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);

        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.UserId == id)); 
        }

        public IResult Update(Customer customer)
        {
            string customerCompany = customer.CompanyName;
            if (customer.CompanyName.Length < 4 && customer.CompanyName != customerCompany)
            {
                return new ErrorResult(Messages.CustemerCompanyNameInvalid);
            }
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
