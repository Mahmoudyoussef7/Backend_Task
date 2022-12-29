using AutoMapper;
using BL.DTO;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class ProductService:IService<Product,ProductVM>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<ProductVM> GetByExpression(Expression<Func<Product, bool>> expression)
        {
            var productList  = _unitOfWork.ProductRepository.GetByExpression(expression).ToList();
            var result = _mapper.Map<List<ProductVM>>(productList);
            return result;
        }

    }
}
