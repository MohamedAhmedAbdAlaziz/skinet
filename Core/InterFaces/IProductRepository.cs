using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.InterFaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}