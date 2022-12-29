using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetByExpression(Expression<Func<T, bool>> expression);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);


    }
}
