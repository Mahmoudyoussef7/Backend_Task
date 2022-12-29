using BL.DTO;
using BL.Services;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IService<Product,ProductVM> _productService;


        public ProductController(IService<Product, ProductVM> productService)
        {
            _productService = productService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult ProductSearch(string str)
        {
            var result = _productService.GetByExpression(p => p.Description.Contains(str));
            return Ok(result);
        }
    }
}
