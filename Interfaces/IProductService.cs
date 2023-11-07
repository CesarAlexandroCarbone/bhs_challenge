using BhsChallenge.Models;

namespace BhsChallenge.Interfaces
{
    public interface IProductService : IGenericListService<Product>
    {
        Task<List<Product>> GetActiveProductsAsync();
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(int productId);
    }
}
