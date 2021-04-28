using System.Threading.Tasks;
using Core.Models;
using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsyc(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}