using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
   public class IneMemory : IIneMemory
    {
        List<Car> _cars;
        public IneMemory()
        {
            _cars = new List<Car>();
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.FirstOrDefault(x => x.Id == car.Id));
        }

        public List<Car> GetAll()
        {
            return _cars; 
        }

        public List<Car> GetById(Car car)
        {
            return _cars.Where(x => x.Id == car.Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(x => x.Id == car.Id);
            carToUpdate.Price = car.Price;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;

        }
    }
}
