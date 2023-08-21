namespace CompanyManagement.WebAPI.Areas.Project.Controllers
{
    [Area("Project")]
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProjectService _projectService;

        public ProjectController(IMapper mapper, IProjectService projectService)
        {
            _mapper = mapper;
            _projectService = projectService;
        }

        [Authorize]
        [HttpPost("api/[controller]/Create")]
        public async Task<IActionResult> Create(ProjectCreateDto projectCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Yanlış veri girişi yapıldı.");
            }

            var result = await _projectService.CreateAsync(projectCreateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPut("api/[controller]/Update")]
        public async Task<IActionResult> Update(ProjectUpdateDto projectUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Yanlış veri girişi yapıldı.");
            }

            var result = await _projectService.UpdateAsync(projectUpdateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpDelete("api/[controller]/Delete")]
        public async Task<IActionResult> Delete(Guid projectId)
        {
            var result = await _projectService.DeleteAsync(projectId);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _projectService.GetAllAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetActive")]
        public async Task<IActionResult> GetActive()
        {
            var result = await _projectService.GetActiveAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetPassive")]
        public async Task<IActionResult> GetPassive()
        {
            var result = await _projectService.GetPassiveAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }
    }
}
