using MyMart.Core.Entities;
using MyMart.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyMart.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
            => await _repository.GetAllAsync();

        public async Task<Product> GetProductByIdAsync(int id)
            => await _repository.GetByIdAsync(id);

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
            => await _repository.GetProductsByCategoryAsync(categoryId);

        public async Task AddProductAsync(Product product)
        {
            await _repository.AddAsync(product);
            await _repository.SaveAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            _repository.Update(product);
            await _repository.SaveAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product != null)
            {
                _repository.Delete(product);
                await _repository.SaveAsync();
            }
        }
    }
}
