using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context):base(context)
        {
        }

        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }
        IQueryable<Product> GetByExpression(Expression<Func<Product, bool>> expression)
        {
            return _context.Products.Where(expression);
        }

        IQueryable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        Product GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
