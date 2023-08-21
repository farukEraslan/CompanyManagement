namespace CompanyManagement.WebAPI.Areas.Supplier.Controllers
{
    [Area("Supplier")]
    [ApiController]
    public class SupplierController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISupplierService _supplierService;

        public SupplierController(IMapper mapper, ISupplierService supplierService)
        {
            _mapper = mapper;
            _supplierService = supplierService;
        }

        [Authorize]
        [HttpPost("api/[controller]/Create")]
        public async Task<IActionResult> Create(SupplierCreateDto supplierCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Yanlış veri girişi yapıldı.");
            }

            var result = await _supplierService.CreateAsync(supplierCreateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPut("api/[controller]/Update")]
        public async Task<IActionResult> Update(SupplierUpdateDto supplierUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Yanlış veri girişi yapıldı.");
            }

            var result = await _supplierService.UpdateAsync(supplierUpdateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpDelete("api/[controller]/Delete")]
        public async Task<IActionResult> Delete(Guid supplierId)
        {
            var result = await _supplierService.DeleteAsync(supplierId);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _supplierService.GetAllAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetActive")]
        public async Task<IActionResult> GetActive()
        {
            var result = await _supplierService.GetActiveAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetPassive")]
        public async Task<IActionResult> GetPassive()
        {
            var result = await _supplierService.GetPassiveAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }
    }
}
