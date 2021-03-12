using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.VoidResults;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAllUsers();
        IResult Update(User user);
        IResult Delete(User user);
        IResult Add(User user);


    }
}
