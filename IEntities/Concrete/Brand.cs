using IEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEntities.Concrete
{
   public class Brand:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
