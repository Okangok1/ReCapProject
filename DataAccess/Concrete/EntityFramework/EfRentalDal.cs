using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using IEntities.Concrete;
using IEntities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyDataBaseContext>, IRentalDal
    {

    }
}
