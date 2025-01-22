using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task<Product?> GetProductByIdAsync(int id);
    Task<Product> AddProductAsync(Product product);
    Task<bool> UpdateProductAsync(int id, Product updatedProduct);
    Task<bool> DeleteProductAsync(int id);
}
