namespace CompanyManagement.Business.Concrete
{
    public class SupplierProductManager : ISupplierProductService
    {
        private readonly IMapper _mapper;
        private readonly ISupplierProductRepository _supplierProductRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IProductRepository _productRepository;

        public SupplierProductManager(IMapper mapper, ISupplierProductRepository supplierProductRepository, ISupplierRepository supplierRepository, IProductRepository productRepository)
        {
            _mapper = mapper;
            _supplierProductRepository = supplierProductRepository;
            _supplierRepository = supplierRepository;
            _productRepository = productRepository;
        }

        public async Task<IResult> CreateAsync(SupplierProductCreateDto supplierProductCreateDto)
        {
            bool hasSupplierProduct = await _supplierProductRepository.AnyAsync(x => x.SupplierId == supplierProductCreateDto.SupplierId && x.ProductId == supplierProductCreateDto.ProductId);
            if (hasSupplierProduct)
            {
                return new ErrorDataResult<SupplierProductDto>("Tedarikçinin ürünü zaten var.");
            }
            var newSupplierProduct = await _supplierProductRepository.AddAsync(_mapper.Map<SupplierProduct>(supplierProductCreateDto));
            await _supplierProductRepository.SaveChangesAsync();
            return new SuccessResult("Tedarikçinin ürünü başarı ile eklendi.");
        }

        public async Task<IResult> UpdateAsync(SupplierProductUpdateDto supplierProductUpdateDto)
        {
            var supplierProduct = await _supplierProductRepository.GetByIdAsync(supplierProductUpdateDto.Id);
            if (supplierProduct == null)
            {
                return new ErrorResult("Tedarikçinin ürünü bulunamadı.");
            }
            var updatedSupplierProduct = await _supplierProductRepository.UpdateAsync(_mapper.Map(supplierProductUpdateDto, supplierProduct));
            await _supplierProductRepository.SaveChangesAsync();
            return new SuccessResult("Tedarikçinin ürünü başarı ile güncellendi.");
        }

        public async Task<IResult> DeleteAsync(Guid supplierProductId)
        {
            var supplierProduct = await _supplierProductRepository.GetByIdAsync(supplierProductId);
            await _supplierProductRepository.DeleteAsync(supplierProduct);
            await _supplierProductRepository.SaveChangesAsync();
            return new SuccessResult("Tedarikçinin ürünü başarı ile silindi.");
        }

        public async Task<IResult> GetAllAsync()
        {
            var supplierProducts = await _supplierProductRepository.GetAllAsync();
            //foreach (var supplierProduct in supplierProducts)
            //{
            //    var customer = await _customerRepository.GetByIdAsync(supplierProduct.SupplierProductId);
            //    var tedarikçict = await _tedarikçictRepository.GetByIdAsync(supplierProduct.TedarikçictId);
            //    var supplierProductDto = new SupplierProductDto();
            //    supplierProductDto.Tedarikçict = tedarikçict.Name;
            //    supplierProductDto.SupplierProduct = customer.Name;
            //}
            return new SuccessDataResult<List<SupplierProductDto>>(_mapper.Map<List<SupplierProductDto>>(supplierProducts), "Tedarikçinin ürünleri başarı ile listelendi.");
        }

        public async Task<IResult> GetActiveAsync()
        {
            var activeSupplierProducts = await _supplierProductRepository.GetAllAsync();
            //foreach (var activeSupplierProduct in activeSupplierProducts)
            //{
            //    activeSupplierProduct.SupplierProduct = await _customerRepository.GetByIdAsync(activeSupplierProduct.SupplierProductId);
            //    activeSupplierProduct.Tedarikçict = await _tedarikçictRepository.GetByIdAsync(activeSupplierProduct.TedarikçictId);
            //}
            return new SuccessDataResult<List<SupplierProductDto>>(_mapper.Map<List<SupplierProductDto>>(activeSupplierProducts), "Aktif tedarikçinin ürünleri başarı ile listelendi.");
        }

        public async Task<IResult> GetPassiveAsync()
        {
            var passiveSupplierProducts = await _supplierProductRepository.GetAllDeletedAsync();
            //foreach (var passiveSupplierProduct in passiveSupplierProducts)
            //{
            //    passiveSupplierProduct.SupplierProduct = await _customerRepository.GetByIdAsync(passiveSupplierProduct.SupplierProductId);
            //    passiveSupplierProduct.Tedarikçict = await _tedarikçictRepository.GetByIdAsync(passiveSupplierProduct.TedarikçictId);
            //}
            return new SuccessDataResult<List<SupplierProductDto>>(_mapper.Map<List<SupplierProductDto>>(passiveSupplierProducts), "Pasif tedarikçinin ürünleri başarı ile listelendi.");
        }

        public async Task<IResult> GetByIdAsync(Guid supplierProductId)
        {
            var supplierProduct = await _supplierProductRepository.GetByIdAsync(supplierProductId);
            //supplierProduct.SupplierProduct = await _customerRepository.GetByIdAsync(supplierProduct.SupplierProductId);
            //supplierProduct.Tedarikçict = await _tedarikçictRepository.GetByIdAsync(supplierProduct.TedarikçictId);
            return new SuccessDataResult<SupplierProductDto>(_mapper.Map<SupplierProductDto>(supplierProduct), "Tedarikçinin ürünü başarı ile listelendi.");
        }
    }
}
