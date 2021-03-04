﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfCustomerDal:EfEntityRepositoryBase<Customer,MyDataBaseContext> ,ICustomerDal
    {
    }
}