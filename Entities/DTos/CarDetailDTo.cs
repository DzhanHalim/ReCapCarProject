using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTos
{
  public  class CarDetailDTo:IDto
    {
        public string Description { get; set; }
        public int  Price { get; set; }

        public string BrandName { get; set; }
        public string  ColorName{ get; set; }
        
    }
}
