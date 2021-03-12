using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.VoidResults;
using Entities;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
     public interface ICarService 
    {
        IDataResult<List<Car>> GetAllCars();
        IDataResult<List<Car>> GetAllBydId(int Id);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);

        IDataResult<List<CarDetailDTo>> GetCarDetails();

        IResult Update(Car car);
        IResult Add(Car car);
        IResult Delete(Car car);
    }
}
