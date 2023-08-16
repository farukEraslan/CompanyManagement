using CompanyManagement.Dtos.Customer;
using CompanyManagement.Entities.Concrete;

namespace CompanyManagement.Business.Concrete
{
    public class CustomerProjectManager : ICustomerProjectService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerProjectRepository _customerProjectRepository;

        public CustomerProjectManager(IMapper mapper, ICustomerProjectRepository customerProjectRepository)
        {
            _mapper = mapper;
            _customerProjectRepository = customerProjectRepository;
        }

        public async Task<IResult> CreateAsync(CustomerProjectCreateDto customerProjectCreateDto)
        {
            bool hasCustomerProject = await _customerProjectRepository.AnyAsync(x => x.ProjectId == customerProjectCreateDto.ProjectId && x.CustomerId == customerProjectCreateDto.CustomerId);
            if (hasCustomerProject)
            {
                return new ErrorDataResult<CustomerDto>("Müşterinin projesi zaten var.");
            }
            var newCustomerProject = await _customerProjectRepository.AddAsync(_mapper.Map<CustomerProject>(customerProjectCreateDto));
            await _customerProjectRepository.SaveChangesAsync();
            return new SuccessResult("Müşteri başarı ile eklendi.");
        }

        public async Task<IResult> UpdateAsync(CustomerProjectUpdateDto customerProjectUpdateDto)
        {
            var customerProject = await _customerProjectRepository.GetByIdAsync(customerProjectUpdateDto.Id);
            if (customerProject == null)
            {
                return new ErrorResult("Müşterinin projesi bulunamadı.");
            }
            var updatedCustomerProject = await _customerProjectRepository.UpdateAsync(_mapper.Map(customerProjectUpdateDto, customerProject));
            await _customerProjectRepository.SaveChangesAsync();
            return new SuccessResult("Müşterinin projesi başarı ile güncellendi.");
        }

        public async Task<IResult> DeleteAsync(Guid customerProjectId)
        {
            var customerProject = await _customerProjectRepository.GetByIdAsync(customerProjectId);
            await _customerProjectRepository.DeleteAsync(customerProject);
            await _customerProjectRepository.SaveChangesAsync();
            return new SuccessResult("Müşterinin projesi başarı ile silindi.");
        }

        public async Task<IResult> GetAllAsync()
        {
            var customerProjects = await _customerProjectRepository.GetAllAsync();
            return new SuccessDataResult<CustomerProjectDto>(_mapper.Map<CustomerProjectDto>(customerProjects), "Müşterilerin projeleri başarı ile listelendi.");
        }

        public async Task<IResult> GetActiveAsync()
        {
            var activeCustomerProjects = await _customerProjectRepository.GetAllAsync(x => x.Status == Status.Deleted!);
            return new SuccessDataResult<CustomerProjectDto>(_mapper.Map<CustomerProjectDto>(activeCustomerProjects), "Aktif müşterilerin projeleri başarı ile listelendi.");
        }

        public async Task<IResult> GetPassiveAsync()
        {
            var passiveCustomerProjects = await _customerProjectRepository.GetAllAsync(x => x.Status == Status.Deleted);
            return new SuccessDataResult<CustomerProjectDto>(_mapper.Map<CustomerProjectDto>(passiveCustomerProjects), "Pasif müşterilerin projeleri başarı ile listelendi.");
        }

        public async Task<IResult> GetByIdAsync(Guid customerProjectId)
        {
            var customerProjects = await _customerProjectRepository.GetByIdAsync(customerProjectId);
            return new SuccessDataResult<CustomerProjectDto>(_mapper.Map<CustomerProjectDto>(customerProjects), "Müşteri başarı ile listelendi.");
        }       

    }
}
