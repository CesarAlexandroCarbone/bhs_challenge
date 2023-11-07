using BhsChallenge.Models;

namespace BhsChallenge.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<List<Product>> GetActiveProductsAsync();
    }
}
