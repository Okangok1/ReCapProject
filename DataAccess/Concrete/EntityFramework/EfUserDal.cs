using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using IEntities.Concrete;
using IEntities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, MyDataBaseContext>, IUserDal
    {
       
    }
  
}

