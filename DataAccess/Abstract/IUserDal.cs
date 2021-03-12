using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IUserDal : IEntityRepository<User>
    {
    }
}
