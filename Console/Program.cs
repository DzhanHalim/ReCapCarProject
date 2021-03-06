﻿using Business;
using DataAccess;
using Entities;
 

namespace Console
{
    using Business.Concrete;
    using Business.Cosntants;
    using DataAccess.Concrete.EntityFramework;
    using DataAccess.Concrete.InMemory;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager(new EfCustomerDal());
            UserManager usermanager = new UserManager(new EfUserDal());
            User user = new User { Email = "can@gmail.com", FirstName = "Dzhan", LastName = "Halim", Password = "password" };
            usermanager.Add(user);
            Customer customer = new Customer {Id=1, CompanyName = "Odisee" };
            
            Rental rental = new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Today, ReturnDate = DateTime.Today.AddDays(5) };
            
             
             
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car { BrandId = 1, ColorId = 2, Description = "Mercedes-Benz",   ModelYear = 2000, Price = 150 };
            Car car2 = new Car { BrandId = 2, ColorId = 3, Description = "Volvo D40",   ModelYear = 2000, Price = 150 };
            Car car3 = new Car { BrandId = 3, ColorId = 1, Description = "Audi A3",    ModelYear = 2000, Price = 200 };

            Car carToUpdate = new Car { BrandId = 3, ColorId = 3, Description = "Mercedes2", Id = 5, ModelYear = 2000, Price = 200 };

            // operation add a new car


            RentalManager rentalManager = new RentalManager(new EfRentalDal());
          
            // carManager.GetAllBydId(5);
            // carManager.GetCarsByBrandId(3);
            // carManager.GetCarsByColorId(3);

            // operation update
            //carManager.Update(carToUpdate);

            var result2 = rentalManager.GetAllRentals();
            if (result2.Success)
            {
                foreach (var item in result2.Data)
                {
                    Console.WriteLine(item.CarId + " " + item.CustomerId + " " + item.RentDate);
                }

            }
            else
            {
                Console.WriteLine(result2.Message);
            }
             

            // operation get all cars
            var result = carManager.GetCarDetails();
            if(result.Success)
            {

           
            foreach (var item in result.Data)
            {
                //carManager.Delete(item);
                Console.WriteLine(item.Description + item.BrandName + " / " + item.ColorName + " / " + item.Price);
                    
            }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);

            }
            // operation get a car by his id
            //foreach (var item in carManager.GetAllBydId(5))
            //{
            //    //carManager.Delete(item);
            //    Console.WriteLine(item.Description + " / " );
            //}

            // deleteing operation
            //carManager.Delete(car2);

            Console.ReadLine();
        }
    }
}
