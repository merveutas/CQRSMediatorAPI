using CQRSMediator.Domain.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSMediator.Domain.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetByIdAsync(int id);
        Task<Product> CreateProductAsync(Product product);
        Task<int> UpdateProductsAsync(int id, Product product);
        Task<int> DeleteProductsAsync(int id);
    }
}
