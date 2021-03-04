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
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarDataBaseContext context = new CarDataBaseContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.UserId
                             select new RentalDetailDto { UserId = u.UserId };
                            return result.ToList();

            }
            
        }
    }
  
}

