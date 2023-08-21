namespace CompanyManagement.Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private readonly IMapper _mapper;
        private readonly IProjectRepository _projectRepository;

        public ProjectManager(IMapper mapper, IProjectRepository projectRepository)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
        }

        public async Task<IResult> CreateAsync(ProjectCreateDto projectCreateDto)
        {
            bool hasProject = await _projectRepository.AnyAsync(x => x.Name.ToLower() == projectCreateDto.Name.ToLower());
            if (hasProject)
            {
                return new ErrorResult("Proje zaten var.");
            }
            var newProject = await _projectRepository.AddAsync(_mapper.Map<Project>(projectCreateDto));
            await _projectRepository.SaveChangesAsync();
            return new SuccessResult("Proje başarı ile eklendi.");
        }

        public async Task<IResult> UpdateAsync(ProjectUpdateDto projectUpdateDto)
        {
            var project = await _projectRepository.GetByIdAsync(projectUpdateDto.Id);
            if (project == null)
            {
                return new ErrorResult("Proje bulunamadı.");
            }
            var updatedProject = await _projectRepository.UpdateAsync(_mapper.Map(projectUpdateDto, project));
            await _projectRepository.SaveChangesAsync();
            return new SuccessResult("Proje başarı ile güncellendi.");
        }

        public async Task<IResult> DeleteAsync(Guid projectId)
        {
            var project = await _projectRepository.GetByIdAsync(projectId);
            await _projectRepository.DeleteAsync(project);
            await _projectRepository.SaveChangesAsync();
            return new SuccessResult("Proje başarı ile silindi.");
        }

        public async Task<IResult> GetByIdAsync(Guid projectId)
        {
            var project = await _projectRepository.GetByIdAsync(projectId);
            return new SuccessDataResult<ProjectDto>(_mapper.Map<ProjectDto>(project), "Proje başarı ile listelendi.");
        }

        public async Task<IResult> GetAllAsync()
        {
            var projects = await _projectRepository.GetAllAsync();
            return new SuccessDataResult<List<ProjectDto>>(_mapper.Map<List<ProjectDto>>(projects), "Projeler başarı ile listelendi.");
        }

        public async Task<IResult> GetActiveAsync()
        {
            var activeProjects = await _projectRepository.GetAllAsync();
            return new SuccessDataResult<List<ProjectDto>>(_mapper.Map<List<ProjectDto>>(activeProjects), "Aktif projeler başarı ile listelendi.");
        }

        public async Task<IResult> GetPassiveAsync()
        {
            var passiveProjects= await _projectRepository.GetAllDeletedAsync();
            return new SuccessDataResult<List<ProjectDto>>(_mapper.Map<List<ProjectDto>>(passiveProjects), "Pasif projeler başarı ile listelendi.");
        }
    }
}
