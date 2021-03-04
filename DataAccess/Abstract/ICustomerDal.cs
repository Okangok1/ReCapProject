using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICustomerDal:IEntityRepository <Customer>
    {
        public List<RentDetailDto> GetRentDetails()
        {
            using (CarDataBaseContext context = new CarDataBaseContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.UserId
                             select new RentDetailDto { UserId = u.UserId };
                return result.ToList();

            }
        }
    }
}
