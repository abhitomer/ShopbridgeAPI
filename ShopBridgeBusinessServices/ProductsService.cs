using AutoMapper;
using ShopBridgeBusinessEntities;
using ShopBridgeDataModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridgeBusinessServices
{
    public class ProductsService : IProductsService
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitOfWork;
        private readonly IGenericRepository<Products> _genericRepository;

        public ProductsService(IUnitofWork unitofWork, IGenericRepository<Products> genericRepository, IMapper mapper)
        {
            _unitOfWork = unitofWork;
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateProductAsync(ProductEntity argProductEntity)
        {
            var itemData = _mapper.Map<Products>(argProductEntity);

            using (var transaction = _unitOfWork.BeginTransaction())
            {
                await _genericRepository.InsertAsync(itemData).ConfigureAwait(false);
                await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
                transaction.Commit();
            }
            return itemData.Id;
        }

        public async Task<bool> DeleteProductAsync(int argProductId)
        {
            var fetchItem = await _genericRepository.GetByIDAsync(argProductId);

            if (fetchItem == null)
                return false;

            _genericRepository.Delete(fetchItem);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }

        public async Task<IEnumerable<ProductEntity>> GetAllProductsAsync()
        {
            var product = await _genericRepository.GetAllAsync();
            if (product != null)
            {
                var dest = _mapper.Map<IEnumerable<ProductEntity>>(product);
                return dest;
            }
            return null;
        }

        public async Task<ProductEntity> GetProductByIdAsync(int argProductId)
        {
            var product = await _genericRepository.GetByIDAsync(argProductId);
            if (product != null)
            {
                var dest = _mapper.Map<ProductEntity>(product);
                return dest;
            }
            return null;
        }

        public async Task<bool> UpdateProductAsync(int argProductId, ProductEntity argProductEntity)
        {
            using var transaction = _unitOfWork.BeginTransaction();
            var fetchItem = await _genericRepository.GetByIDAsync(argProductId);

            if (fetchItem == null)
                return false;

            fetchItem.Name = argProductEntity.Name;
            fetchItem.Description = argProductEntity.Description;
            fetchItem.Price = argProductEntity.Price;

            _genericRepository.Update(fetchItem);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            transaction.Commit();
            return true;
        }
    }
}
