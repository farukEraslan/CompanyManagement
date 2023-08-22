namespace CompanyManagement.Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        private readonly IMapper _mapper;
        private readonly ISupplierRepository _supplierRepository;

        public SupplierManager(IMapper mapper, ISupplierRepository supplierRepository)
        {
            _mapper = mapper;
            _supplierRepository = supplierRepository;
        }

        public async Task<IResult> CreateAsync(SupplierCreateDto supplierCreateDto)
        {
            bool hasSupplier = await _supplierRepository.AnyAsync(x => x.Name.ToLower() == supplierCreateDto.Name.ToLower());
            if (hasSupplier)
            {
                return new ErrorResult("Proje zaten var.");
            }
            var newSupplier = await _supplierRepository.AddAsync(_mapper.Map<Supplier>(supplierCreateDto));
            await _supplierRepository.SaveChangesAsync();
            return new SuccessResult("Proje başarı ile eklendi.");
        }

        public async Task<IResult> UpdateAsync(SupplierUpdateDto supplierUpdateDto)
        {
            var supplier = await _supplierRepository.GetByIdAsync(supplierUpdateDto.Id);
            if (supplier == null)
            {
                return new ErrorResult("Proje bulunamadı.");
            }
            var updatedSupplier = await _supplierRepository.UpdateAsync(_mapper.Map(supplierUpdateDto, supplier));
            await _supplierRepository.SaveChangesAsync();
            return new SuccessResult("Proje başarı ile güncellendi.");
        }

        public async Task<IResult> DeleteAsync(Guid supplierId)
        {
            var supplier = await _supplierRepository.GetByIdAsync(supplierId);
            await _supplierRepository.DeleteAsync(supplier);
            await _supplierRepository.SaveChangesAsync();
            return new SuccessResult("Proje başarı ile silindi.");
        }

        public async Task<IResult> GetByIdAsync(Guid supplierId)
        {
            var supplier = await _supplierRepository.GetByIdAsync(supplierId);
            return new SuccessDataResult<SupplierDto>(_mapper.Map<SupplierDto>(supplier), "Proje başarı ile listelendi.");
        }

        public async Task<IResult> GetAllAsync()
        {
            var suppliers = await _supplierRepository.GetAllAsync();
            return new SuccessDataResult<List<SupplierDto>>(_mapper.Map<List<SupplierDto>>(suppliers), "Tedarikçiler başarı ile listelendi.");
        }

        public async Task<IResult> GetActiveAsync()
        {
            var activeSuppliers = await _supplierRepository.GetAllAsync();
            return new SuccessDataResult<List<SupplierDto>>(_mapper.Map<List<SupplierDto>>(activeSuppliers), "Aktif projeler başarı ile listelendi.");
        }

        public async Task<IResult> GetPassiveAsync()
        {
            var passiveSuppliers = await _supplierRepository.GetAllDeletedAsync();
            return new SuccessDataResult<List<SupplierDto>>(_mapper.Map<List<SupplierDto>>(passiveSuppliers), "Pasif projeler başarı ile listelendi.");
        }
    }
}
