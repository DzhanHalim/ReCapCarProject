using Business.Abstract;
using Business.Cosntants;
using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.VoidResults;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;

        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }

        public IResult Add(User user)
        {
            _userdal.Add(user);
            return new SuccessResult(Messages.ProductAdded);

        }

        public IResult Delete(User user)
        {
            _userdal.Delete(user);
            return new SuccessResult(Messages.ProductDeleted);

        }

        public IDataResult<List<User>> GetAllUsers()
        {
            return new SuccessDataResult<List<User>>(_userdal.GetAll(), Messages.ProductsListed);

        }

        public IResult Update(User user)
        {
            _userdal.Update(user);
            return new SuccessResult(Messages.ProductUpdated);

        }
    }
}
