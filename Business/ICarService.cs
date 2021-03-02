using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface ICarService
    {
        List<Car> GetById(Car car);

        List<Car> GetAll();

        void Update(Car car);
        void Delete(Car car);
        void Add(Car car);
    }
}
