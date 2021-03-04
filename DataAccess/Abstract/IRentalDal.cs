using Core.DataAccess.EntityFramework;
using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IRentalDal:IEntityRepository<Rental>
    {
    }
}
