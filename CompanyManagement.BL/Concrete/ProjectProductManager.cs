namespace CompanyManagement.Business.Concrete
{
    public class ProjectProductManager : IProjectProductService
    {
        private readonly IMapper _mapper;
        private readonly IProjectProductRepository _projectProductRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IProductRepository _productRepository;

        public ProjectProductManager(IMapper mapper, IProjectProductRepository projectProductRepository, IProjectRepository projectRepository, IProductRepository productRepository)
        {
            _mapper = mapper;
            _projectProductRepository = projectProductRepository;
            _projectRepository = projectRepository;
            _productRepository = productRepository;

        }

        public async Task<IResult> CreateAsync(ProjectProductCreateDto projectProductCreateDto)
        {
            bool hasProjectProduct = await _projectProductRepository.AnyAsync(x => x.ProjectId == projectProductCreateDto.ProjectId && x.ProductId == projectProductCreateDto.ProductId);
            if (hasProjectProduct)
            {
                return new ErrorDataResult<ProjectProductDto>("Projenin ürünü zaten var.");
            }
            var newProjectProduct = await _projectProductRepository.AddAsync(_mapper.Map<ProjectProduct>(projectProductCreateDto));
            await _projectProductRepository.SaveChangesAsync();
            return new SuccessResult("Projenin ürünü başarı ile eklendi.");
        }

        public async Task<IResult> UpdateAsync(ProjectProductUpdateDto projectProductUpdateDto)
        {
            var projectProduct = await _projectProductRepository.GetByIdAsync(projectProductUpdateDto.Id);
            if (projectProduct == null)
            {
                return new ErrorResult("Projenin ürünü bulunamadı.");
            }
            var updatedProjectProduct = await _projectProductRepository.UpdateAsync(_mapper.Map(projectProductUpdateDto, projectProduct));
            await _projectProductRepository.SaveChangesAsync();
            return new SuccessResult("Projenin ürünü başarı ile güncellendi.");
        }

        public async Task<IResult> DeleteAsync(Guid projectProductId)
        {
            var projectProduct = await _projectProductRepository.GetByIdAsync(projectProductId);
            await _projectProductRepository.DeleteAsync(projectProduct);
            await _projectProductRepository.SaveChangesAsync();
            return new SuccessResult("Projenin ürünü başarı ile silindi.");
        }

        public async Task<IResult> GetAllAsync()
        {
            var projectProducts = await _projectProductRepository.GetAllAsync();
            //foreach (var projectProduct in projectProducts)
            //{
            //    var customer = await _customerRepository.GetByIdAsync(projectProduct.ProjectProductId);
            //    var project = await _projectRepository.GetByIdAsync(projectProduct.ProjectId);
            //    var projectProductDto = new ProjectProductDto();
            //    projectProductDto.Project = project.Name;
            //    projectProductDto.ProjectProduct = customer.Name;
            //}
            return new SuccessDataResult<List<ProjectProductDto>>(_mapper.Map<List<ProjectProductDto>>(projectProducts), "Projenin ürünleri başarı ile listelendi.");
        }

        public async Task<IResult> GetActiveAsync()
        {
            var activeProjectProducts = await _projectProductRepository.GetAllAsync();
            //foreach (var activeProjectProduct in activeProjectProducts)
            //{
            //    activeProjectProduct.ProjectProduct = await _customerRepository.GetByIdAsync(activeProjectProduct.ProjectProductId);
            //    activeProjectProduct.Project = await _projectRepository.GetByIdAsync(activeProjectProduct.ProjectId);
            //}
            return new SuccessDataResult<List<ProjectProductDto>>(_mapper.Map<List<ProjectProductDto>>(activeProjectProducts), "Aktif projenin ürünleri başarı ile listelendi.");
        }

        public async Task<IResult> GetPassiveAsync()
        {
            var passiveProjectProducts = await _projectProductRepository.GetAllDeletedAsync();
            //foreach (var passiveProjectProduct in passiveProjectProducts)
            //{
            //    passiveProjectProduct.ProjectProduct = await _customerRepository.GetByIdAsync(passiveProjectProduct.ProjectProductId);
            //    passiveProjectProduct.Project = await _projectRepository.GetByIdAsync(passiveProjectProduct.ProjectId);
            //}
            return new SuccessDataResult<List<ProjectProductDto>>(_mapper.Map<List<ProjectProductDto>>(passiveProjectProducts), "Pasif projenin ürünleri başarı ile listelendi.");
        }

        public async Task<IResult> GetByIdAsync(Guid projectProductId)
        {
            var projectProduct = await _projectProductRepository.GetByIdAsync(projectProductId);
            //projectProduct.ProjectProduct = await _customerRepository.GetByIdAsync(projectProduct.ProjectProductId);
            //projectProduct.Project = await _projectRepository.GetByIdAsync(projectProduct.ProjectId);
            return new SuccessDataResult<ProjectProductDto>(_mapper.Map<ProjectProductDto>(projectProduct), "Projenin ürünü başarı ile listelendi.");
        }
    }
}
