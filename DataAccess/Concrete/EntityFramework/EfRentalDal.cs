using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.DTos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
namespace DataAccess.Concrete.EntityFramework
{
   public class EfRentalDal: EfEntitiyRepositoryBase<Rental,CarsContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using(CarsContext context= new CarsContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join u in context.Users
                             on r.CustomerId equals u.Id
                             select new RentalDetailDto
                             {
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 CarName = c.Description,
                                 FirstName = u.FirstName,
                                 Email = u.Email,
                                 LastName = u.LastName

                             };
                return result.ToList();

            }
        }
    }
}
