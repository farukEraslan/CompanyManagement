using CompanyManagement.Dtos.Customer;
using CompanyManagement.Entities.Concrete;

namespace CompanyManagement.Business.Concrete
{
    public class CustomerProjectManager : ICustomerProjectService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerProjectRepository _customerProjectRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IProjectRepository _projectRepository;

        public CustomerProjectManager(IMapper mapper, ICustomerProjectRepository customerProjectRepository, ICustomerRepository customerRepository, IProjectRepository projectRepository)
        {
            _mapper = mapper;
            _customerProjectRepository = customerProjectRepository;
            _customerRepository = customerRepository;
            _projectRepository = projectRepository;
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
            //foreach (var customerProject in customerProjects)
            //{
            //    var customer = await _customerRepository.GetByIdAsync(customerProject.CustomerId);
            //    var project = await _projectRepository.GetByIdAsync(customerProject.ProjectId);
            //    var customerProjectDto = new CustomerProjectDto();
            //    customerProjectDto.Project = project.Name;
            //    customerProjectDto.Customer = customer.Name;
            //}
            return new SuccessDataResult<List<CustomerProjectDto>>(_mapper.Map<List<CustomerProjectDto>>(customerProjects), "Müşterilerin projeleri başarı ile listelendi.");
        }

        public async Task<IResult> GetActiveAsync()
        {
            var activeCustomerProjects = await _customerProjectRepository.GetAllAsync();
            //foreach (var activeCustomerProject in activeCustomerProjects)
            //{
            //    activeCustomerProject.Customer = await _customerRepository.GetByIdAsync(activeCustomerProject.CustomerId);
            //    activeCustomerProject.Project = await _projectRepository.GetByIdAsync(activeCustomerProject.ProjectId);
            //}
            return new SuccessDataResult<List<CustomerProjectDto>>(_mapper.Map<List<CustomerProjectDto>>(activeCustomerProjects), "Aktif müşterilerin projeleri başarı ile listelendi.");
        }

        public async Task<IResult> GetPassiveAsync()
        {
            var passiveCustomerProjects = await _customerProjectRepository.GetAllDeletedAsync();
            //foreach (var passiveCustomerProject in passiveCustomerProjects)
            //{
            //    passiveCustomerProject.Customer = await _customerRepository.GetByIdAsync(passiveCustomerProject.CustomerId);
            //    passiveCustomerProject.Project = await _projectRepository.GetByIdAsync(passiveCustomerProject.ProjectId);
            //}
            return new SuccessDataResult<List<CustomerProjectDto>>(_mapper.Map<List<CustomerProjectDto>>(passiveCustomerProjects), "Pasif müşterilerin projeleri başarı ile listelendi.");
        }

        public async Task<IResult> GetByIdAsync(Guid customerProjectId)
        {
            var customerProject = await _customerProjectRepository.GetByIdAsync(customerProjectId);
            //customerProject.Customer = await _customerRepository.GetByIdAsync(customerProject.CustomerId);
            //customerProject.Project = await _projectRepository.GetByIdAsync(customerProject.ProjectId);
            return new SuccessDataResult<CustomerProjectDto>(_mapper.Map<CustomerProjectDto>(customerProject), "Müşteri başarı ile listelendi.");
        }       

    }
}
