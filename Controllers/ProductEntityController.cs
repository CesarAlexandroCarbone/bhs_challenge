using BhsChallenge.Interfaces;
using BhsChallenge.Models;
using Microsoft.AspNetCore.Mvc;

namespace BhsChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductEntityController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductEntityController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("products")]
        public async Task<List<Product>> ListActiveProductsAsync()
        {
            return await _productService.GetActiveProductsAsync();
        }
    }
}
