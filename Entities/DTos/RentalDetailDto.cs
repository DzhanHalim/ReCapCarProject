using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTos
{
  public  class RentalDetailDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string CarName { get; set; }

    }
}
