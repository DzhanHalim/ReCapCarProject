using Business.Abstract;
using Business.Cosntants;
using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.VoidResults;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal carDal;

        public CarManager(ICarDal carDal)
        {
            this.carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            if(car.Price <= 0)
            {
                return new ErrorResult(Messages.ProductPriceInvalid);


            }
            
                carDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);
            
        }

        public IResult Delete(Car car)
        {
            carDal.Delete(car);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Car>> GetAllBydId(int Id)
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(x=> x.Id==Id), Messages.ProductsListed);
        }

        public IDataResult<List<Car>> GetAllCars()
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<CarDetailDTo>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDTo>>(carDal.GetCarDetails(), Messages.ProductsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(x=>x.BrandId== id), Messages.ProductsListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(x => x.ColorId == id),Messages.ProductsListed);
        }

        public IResult Update(Car car)
        {
            carDal.Update(car);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
