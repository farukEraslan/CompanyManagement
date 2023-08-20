namespace CompanyManagement.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<IResult> CreateAsync(CustomerCreateDto customerCreateDto)
        {
            bool hasCustomer = await _customerRepository.AnyAsync(x=>x.Name.ToLower() == customerCreateDto.Name.ToLower());
            if (hasCustomer)
            {
                return new ErrorResult("Müşteri zaten var.");
            }
            var newCustomer = await _customerRepository.AddAsync(_mapper.Map<Customer>(customerCreateDto));
            await _customerRepository.SaveChangesAsync();
            return new SuccessResult("Müşteri başarı ile eklendi.");
        }

        public async Task<IResult> UpdateAsync(CustomerUpdateDto customerUpdateDto)
        {
            var customer = await _customerRepository.GetByIdAsync(customerUpdateDto.Id);
            if (customer == null)
            {
                return new ErrorResult("Müşteri bulunamadı.");
            }
            var updatedCustomer = await _customerRepository.UpdateAsync(_mapper.Map(customerUpdateDto, customer));
            await _customerRepository.SaveChangesAsync();
            return new SuccessResult("Müşteri başarı ile güncellendi.");
        }

        public async Task<IResult> DeleteAsync(Guid customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);
            await _customerRepository.DeleteAsync(customer);
            await _customerRepository.SaveChangesAsync();
            return new SuccessResult("Müşteri başarı ile silindi.");
        }

        public async Task<IResult> GetByIdAsync(Guid customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);
            return new SuccessDataResult<CustomerDto>(_mapper.Map<CustomerDto>(customer), "Müşteri başarı ile listelendi.");
        }

        public async Task<IResult> GetAllAsync()
        {
            var customers = await _customerRepository.GetAllAsync();
            return new SuccessDataResult<CustomerDto>(_mapper.Map<CustomerDto>(customers), "Müşteriler başarı ile listelendi.");
        }

        public async Task<IResult> GetActiveAsync()
        {
            var activeCustomers = await _customerRepository.GetAllAsync(x=>x.Status == Status.Deleted!);
            return new SuccessDataResult<CustomerDto>(_mapper.Map<CustomerDto>(activeCustomers), "Aktif müşteriler başarı ile listelendi.");
        }

        public async Task<IResult> GetPassiveAsync()
        {
            var activeCustomers = await _customerRepository.GetAllAsync(x => x.Status == Status.Deleted);
            return new SuccessDataResult<CustomerDto>(_mapper.Map<CustomerDto>(activeCustomers), "Pasif müşteriler başarı ile listelendi.");
        }             

    }
}
