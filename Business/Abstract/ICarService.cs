using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
     public interface ICarService 
    {
        List<Car> GetAllCars();
        List<Car> GetAllBydId(int Id);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void Update(Car car);
        void Add(Car car);
        void Delete(Car car);
    }
}
