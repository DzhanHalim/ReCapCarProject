using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface ICar
    {
          int Id { get; set; }
          int BrandId { get; set; }
          int ColorId { get; set; }
          int ModelYear { get; set; }
          int Price { get; set; }
          string Description { get; set; }
    }
}
