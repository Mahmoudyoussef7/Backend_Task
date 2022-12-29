using BL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public interface IService<T,TVM> where T : class, new() where TVM : class, new()
    {
        List<TVM> GetByExpression(Expression<Func<T, bool>> expression);
    }
}
