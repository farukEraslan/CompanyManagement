﻿using CompanyManagement.Business.Abstract;
using CompanyManagement.Core.Utilities.Helpers;
using System.Drawing;

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

        public async Task<IDataResult<ProductQRCodeDto>> CreateAsync(ProductCreateDto productCreateDto)
        {
            bool hasProduct = await _productRepository.AnyAsync(x => x.Name.ToLower() == productCreateDto.Name.ToLower());
            if (hasProduct)
            {
                return new ErrorDataResult<ProductQRCodeDto>("Ürün zaten var.");
            }
            var newProduct = await _productRepository.AddAsync(_mapper.Map<Product>(productCreateDto));
            await _productRepository.SaveChangesAsync();
            return new SuccessDataResult<ProductQRCodeDto>(_mapper.Map<ProductQRCodeDto>(newProduct), "Ürün başarı ile eklendi.");
        }

        public async Task<IResult> UpdateAsync(ProductUpdateDto productUpdateDto)
        {
            var product = await _productRepository.GetByIdAsync(productUpdateDto.Id);
            if (product == null)
            {
                return new ErrorResult("Ürün bulunamadı.");
            }
            var updatedProduct = await _productRepository.UpdateAsync(_mapper.Map(productUpdateDto, product));
            await _productRepository.SaveChangesAsync();
            return new SuccessResult("Ürün başarı ile güncellendi.");
        }

        public async Task<IResult> DeleteAsync(Guid productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);
            await _productRepository.DeleteAsync(product);
            await _productRepository.SaveChangesAsync();
            return new SuccessResult("Ürün başarı ile silindi.");
        }

        public async Task<IResult> GetByIdAsync(Guid productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);
            return new SuccessDataResult<ProductDto>(_mapper.Map<ProductDto>(product), "Ürün başarı ile listelendi.");
        }

        public async Task<IResult> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return new SuccessDataResult<List<ProductDto>>(_mapper.Map<List<ProductDto>>(products), "Ürünler başarı ile listelendi.");
        }

        public async Task<IResult> GetActiveAsync()
        {
            var activeProducts = await _productRepository.GetAllAsync();
            return new SuccessDataResult<List<ProductDto>>(_mapper.Map<List<ProductDto>>(activeProducts), "Aktif ürünler başarı ile listelendi.");
        }

        public async Task<IResult> GetPassiveAsync()
        {
            var passiveProducts = await _productRepository.GetAllDeletedAsync();
            return new SuccessDataResult<List<ProductDto>>(_mapper.Map<List<ProductDto>>(passiveProducts), "Pasif ürünler başarı ile listelendi.");
        }

        //public async Task<Byte[]> CreateQRCode(ProductQRCodeDto productQRCodeDto)
        //{
        //    var productQRCodeData = $"Seri No:{productQRCodeDto.SerialNo}\nÜrün Adı:{productQRCodeDto.Name}\nÜrün Detayı:{productQRCodeDto.Description}\nMarka:{productQRCodeDto.Brand}\nYükseklik:{productQRCodeDto.Height}\nGenişlik:{productQRCodeDto.Width}\nUzunluk:{productQRCodeDto.Lenght}";
        //    var productQRCode = QrCodeHelper.Create(productQRCodeData);

        //    return productQRCode;
        //}

        public async Task<Byte[]> CreateQRCode(Guid productId)
        {
            var productQRCode = QrCodeHelper.Create(productId.ToString());

            return productQRCode;
        }
    }
}
