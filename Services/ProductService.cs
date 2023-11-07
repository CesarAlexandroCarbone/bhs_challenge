using BhsChallenge.Interfaces;
using BhsChallenge.Models;

namespace BhsChallenge.Services
{
    public class ProductService : GenericListService<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetActiveProductsAsync()
        {
            return await _productRepository.GetActiveProductsAsync();
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "O produto não pode ser nulo.");
            }

            return await _productRepository.CreateAsync(product);
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "O produto não pode ser nulo.");
            }

            return await _productRepository.UpdateAsync(product);
        }

        public async Task<bool> DeleteProductAsync(int productId)
        {
            if (productId <= 0)
            {
                throw new ArgumentException("O ID do produto deve ser maior que zero.", nameof(productId));
            }

            return await _productRepository.DeleteAsync(productId);
        }
    }
}
