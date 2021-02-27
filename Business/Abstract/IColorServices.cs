using IEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorServices
    {
        List<Color> GetAll();
    }
}
