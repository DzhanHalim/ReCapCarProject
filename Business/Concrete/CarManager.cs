using Business.Abstract;
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

        public void Add(Car car)
        {
            if (car.Description.Length < 2)
            {
                Console.WriteLine("Car name is too short");
            }
            if(car.Price <= 0)
            {
                Console.WriteLine("Car price can not be less than 0");

            }
            else
            {
                carDal.Add(car);
            }
            
        }

        public void Delete(Car car)
        {
            carDal.Delete(car);
        }

        public List<Car> GetAllBydId(int Id)
        {
            return carDal.GetAll(x=> x.Id==Id);
        }

        public List<Car> GetAllCars()
        {
            return carDal.GetAll();
        }

        public List<CarDetailDTo> GetCarDetails()
        {
            return carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return carDal.GetAll(x=>x.BrandId== id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return carDal.GetAll(x => x.ColorId == id);
        }

        public void Update(Car car)
        {
            carDal.Update(car);
        }
    }
}
