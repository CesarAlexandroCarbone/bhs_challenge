using BhsChallenge.Interfaces;
using BhsChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace BhsChallenge.Data
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly ProductDbContext _productDbContext;

        public ProductRepository(ProductDbContext productDbContext) : base(productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public virtual async Task<List<Product>> GetActiveProductsAsync()
        {
            return await _productDbContext.Set<Product>()
                            .Where(p => p.Status)
                            .ToListAsync();
        }
    }
}
