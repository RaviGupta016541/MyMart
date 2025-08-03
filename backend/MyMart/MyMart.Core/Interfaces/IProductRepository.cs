using MyMart.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMart.Core.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        // Add any product-specific methods here
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);
    }
}
