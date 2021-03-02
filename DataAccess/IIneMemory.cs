using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
   public interface IIneMemory
    {
        List<Car> GetById(Car car);

        List<Car> GetAll();

        void Update(Car car);
        void Delete(Car car);
        void Add(Car car);

    }
}
