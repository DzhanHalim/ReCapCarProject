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
    public class EfCarDal : EfEntitiyRepositoryBase<Car, CarsContext>, ICarDal
    {
        public List<CarDetailDTo> GetCarDetails()
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from c in context.Cars2
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join o in context.Colors
                             on c.ColorId equals o.Id
                             select new CarDetailDTo
                             {
                                 Description=c.Description,
                                 ColorName = o.ColorName,
                                 Price =c.Price,
                                 BrandName=b.BrandName
                                 
                             };
                return result.ToList();
            }
        }
    }
}
