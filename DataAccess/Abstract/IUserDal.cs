using Core.DataAccess.EntityFramework;
using IEntities.Concrete;
using IEntities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
  public interface IUserDal:IEntityRepository <User>
    {
        //List<RentDetailDto> GetRentDetails();
        List<RentalDetailDto> GetRentalDetails();
    }
}
