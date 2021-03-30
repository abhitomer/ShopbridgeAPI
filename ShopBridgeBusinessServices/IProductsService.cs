using ShopBridgeBusinessEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridgeBusinessServices
{
    public interface IProductsService
    {
        Task<ProductEntity> GetProductByIdAsync(int argProductId);
        Task<IEnumerable<ProductEntity>> GetAllProductsAsync();
        Task<int> CreateProductAsync(ProductEntity argProductEntity);
        Task<bool> UpdateProductAsync(int argProductId, ProductEntity argProductEntity);
        Task<bool> DeleteProductAsync(int argProductId);
    }
}
