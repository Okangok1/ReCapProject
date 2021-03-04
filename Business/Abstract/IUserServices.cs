using Business.Utilities.Results;
using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserServices
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);

        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
