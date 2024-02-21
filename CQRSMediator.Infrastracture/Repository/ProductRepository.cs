using CQRSMediator.Domain.Entitiy;
using CQRSMediator.Domain.Repository;
using CQRSMediator.Infrastracture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSMediator.Infrastracture.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _productDbContext;    
        public ProductRepository(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }
        public async Task<Product> CreateProductAsync(Product product)
        {
            _productDbContext.Products.AddAsync(product);
            _productDbContext.SaveChangesAsync();
            return product;
        }

        public async Task<int> DeleteProductsAsync(int id)
        {
           return await _productDbContext.Products.Where(q => q.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productDbContext.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productDbContext.Products.AsNoTracking().FirstOrDefaultAsync(q=>q.Id == id);
        }

        public async Task<int> UpdateProductsAsync(int id, Product product)
        {
            return await _productDbContext.Products.Where(q => q.Id == id).
                ExecuteUpdateAsync(w => w.SetProperty(x => x.Id, product.Id)
                .SetProperty(x => x.Name, product.Name)
                .SetProperty(x => x.Description, product.Description)
                );
        }
    }
}
