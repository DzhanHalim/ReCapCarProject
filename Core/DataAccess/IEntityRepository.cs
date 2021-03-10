using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T: class, IEntity,new()
    {
         
        T Get(Expression<Func<T, bool>> filter);
        //T Get(int id);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
       // List<T> GetAll();

        void Add(T car);
        void Update(T car);
        void Delete(T car);
    }
}
