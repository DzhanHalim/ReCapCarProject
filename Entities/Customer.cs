using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class Customer : IEntity
    {
        public int  Id { get; set; }
        public string CompanyName { get; set; }
    }
}
