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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;

        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }

        public IResult Add(Customer customer)
        {
            _customerdal.Add(customer);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerdal.Delete(customer);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Customer>> GetAllCustomers()
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll(), Messages.ProductsListed);
        }

        public IResult Update(Customer customer)
        {
            _customerdal.Update(customer);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
