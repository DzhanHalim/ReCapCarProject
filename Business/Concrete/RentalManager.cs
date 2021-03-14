using Business.Abstract;
using Business.Cosntants;
using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.VoidResults;
using DataAccess.Abstract;
using Entities;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Rental>> GetAllRentals()
        {
            
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
           
            return  new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), Messages.ProductsListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
