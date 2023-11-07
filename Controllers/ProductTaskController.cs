using BhsChallenge.Interfaces;
using BhsChallenge.Models;
using Microsoft.AspNetCore.Mvc;

namespace BhsChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductTaskController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductTaskController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("products")]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            try
            {
                var createdProduct = await _productService.CreateProductAsync(product);
                return CreatedAtRoute("GetProduct", new { id = createdProduct.Id }, createdProduct);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("products")]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            try
            {
                var updatedProduct = await _productService.UpdateProductAsync(product);
                if (updatedProduct == null)
                {
                    return NotFound();
                }
                return Ok(updatedProduct);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                var result = await _productService.DeleteProductAsync(id);
                if (result)
                {
                    return NoContent();
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
