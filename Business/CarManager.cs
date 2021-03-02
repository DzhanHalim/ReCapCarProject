using DataAccess;
using Entities;
using System;
using System.Collections.Generic;

namespace Business
{
    public class CarManager : ICarService
    {
        IIneMemory _memory;

        public CarManager(IIneMemory memory)
        {
            _memory = memory;
        }

        public void Add(Car car)
        {
            _memory.Add(car);
        }

        public void Delete(Car car)
        {
            _memory.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _memory.GetAll();
        }

        public List<Car> GetById(Car car)
        {
            return _memory.GetById(car);
        }

        public void Update(Car car)
        {
            _memory.Update(car);
        }
    }
}
