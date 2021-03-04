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
    public class UserManager : IUserServices
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        public IResult Update(User user)
        {
            string userName = user.FirstName;
            if (user.FirstName.Length<3 && user.FirstName != userName)
            {
                return new ErrorResult(Messages.UserUpdatedInvalid);
            }
            return new SuccessResult(Messages.UserUpdate);
        }
    }
}
