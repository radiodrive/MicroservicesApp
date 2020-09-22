using Catalog.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(String id);
        Task<IEnumerable<Product>> GetProductByName(String Name);
        Task<IEnumerable<Product>> GetProductByCategory(String CategoryName);

        Task Create(Product product);
        Task<bool> Update(Product product);
        Task<bool> Delete(String id);

    }
}
