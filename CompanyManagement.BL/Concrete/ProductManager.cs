using CompanyManagement.Dtos.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductManager(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<IResult> CreateAsync(ProductCreateDto productCreateDto)
        {
            bool hasProduct = await _productRepository.AnyAsync(x => x.Name.ToLower() == productCreateDto.Name.ToLower());
            if (hasProduct)
            {
                return new ErrorDataResult<ProductDto>("Ürün zaten var.");
            }
            var newProduct = await _productRepository.AddAsync(_mapper.Map<Product>(productCreateDto));
            await _productRepository.SaveChangesAsync();
            return new SuccessResult("Ürün başarı ile eklendi.");
        }

        public Task<IResult> DeleteAsync(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetActiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetByIdAsync(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetPassiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(ProductUpdateDto productUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
