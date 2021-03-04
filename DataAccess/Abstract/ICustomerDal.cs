using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using IEntities.Concrete;
using IEntities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICustomerDal:IEntityRepository <Customer>
    {
        List<RentalDetailDto> GetRentalDetails();
    }
}
