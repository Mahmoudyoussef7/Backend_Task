using DAL.Interfaces;
using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext _context;
        protected DbSet<T> DbSet { get; set; }

        public BaseRepository(ApplicationDbContext context)
        {
            _context= context;
            DbSet = _context.Set<T>();
        }

        public virtual T Add(T entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public virtual void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public virtual IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<T> GetByExpression(Expression<Func<T, bool>> criteria)
        {
            var result = DbSet.Where(criteria);
            return result;
        }

        public virtual T Update(T entity)
        {
            DbSet.Update(entity);
            return entity;
        }

        public IQueryable<T> Search(string str)
        {
            throw new NotImplementedException();
        }
    }
}
