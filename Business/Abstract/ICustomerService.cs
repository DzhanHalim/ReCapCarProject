using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.VoidResults;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerService 
    {
        IDataResult<List<Customer>> GetAllCustomers();
        IDataResult<Customer> GetById(int id);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IResult Add(Customer customer);
    }
}
