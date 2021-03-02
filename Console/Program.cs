using Business;
using DataAccess;
using Entities;
 

namespace Console
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
             

            CarManager carManager = new CarManager(new IneMemory());
            Car car = new Car { BrandId = 1, ColorId = 1, Description = "Volvo", Id = 1, ModelYear = 2000, Price = 150 };


            carManager.Add(car);
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            
            Console.ReadLine();
        }
    }
}
