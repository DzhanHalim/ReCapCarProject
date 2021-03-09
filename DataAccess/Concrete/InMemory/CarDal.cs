using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class CarDal : ICarDal
    {
        List<Car> _car = new List<Car>();
        public void Add(Car car)
        {
            //_car.Add(car);
            using (CarsContext context = new CarsContext())
            {
                var addedEntity = context.Entry(car);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car car)
        {
            //_car.Remove(_car.FirstOrDefault(x => x.Id == car.Id));
            using (CarsContext context = new CarsContext())
            {
                var deletedEntity = context.Entry(car);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarsContext context = new CarsContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

         
        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarsContext context = new CarsContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public void Update(Car car)
        {
            //Car carToUpdate = _car.FirstOrDefault(x => x.Id == car.Id);
            //carToUpdate.ModelYear = car.ModelYear;
            //carToUpdate.Price = car.ModelYear;
            //carToUpdate.Description = car.Description;
            //carToUpdate.ColorId = car.ColorId;
            //carToUpdate.BrandId = car.BrandId;

            using (CarsContext context = new CarsContext())
            {
                var updatedEntity = context.Entry(car);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }


        }
    }
}
