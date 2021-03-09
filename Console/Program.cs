using Business;
using DataAccess;
using Entities;
 

namespace Console
{
    using Business.Concrete;
    using DataAccess.Concrete.InMemory;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
             

            CarManager carManager = new CarManager(new CarDal());
            Car car = new Car { BrandId = 3, ColorId = 3, Description = "Volvo", Id = 3, ModelYear = 2000, Price = 150 };
            Car car2 = new Car { BrandId = 3, ColorId = 3, Description = "Volvo", Id = 4, ModelYear = 2000, Price = 150 };
            Car car3 = new Car { BrandId = 3, ColorId = 3, Description = "Mercedes", Id = 5, ModelYear = 2000, Price = 200 };



            // carManager.Add(car3);
            // carManager.Delete(car3);
            // carManager.GetAllBydId(5);
            //  carManager.GetCarsByBrandId(3);
            // carManager.GetCarsByColorId(3);
            
            foreach (var item in carManager.GetAllCars())
            {
                //carManager.Delete(item);
                Console.WriteLine(item.Description);
            }


            Console.ReadLine();
        }
    }
}
