namespace CompanyManagement.WebAPI.Areas.SupplierProduct.Controllers
{
    public class SupplierProductController : Controller
    {
        private readonly ISupplierProductService _supplierProductService;
        private readonly ISupplierService _supplierService;
        private readonly IProductService _productService;

        public SupplierProductController(ISupplierProductService supplierProductService, ISupplierService supplierService, IProductService productService)
        {
            _supplierProductService = supplierProductService;
            _supplierService = supplierService;
            _productService = productService;
        }

        [Authorize]
        [HttpPost("api/[controller]/Create")]
        public async Task<IActionResult> Create(SupplierProductCreateDto supplierProductCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Yanlış veri girişi yapıldı.");
            }

            var result = await _supplierProductService.CreateAsync(supplierProductCreateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPut("api/[controller]/Update")]
        public async Task<IActionResult> Update(SupplierProductUpdateDto supplierProductUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Yanlış veri girişi yapıldı.");
            }

            var result = await _supplierProductService.UpdateAsync(supplierProductUpdateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpDelete("api/[controller]/Delete")]
        public async Task<IActionResult> Delete(Guid supplierProductId)
        {
            var result = await _supplierProductService.DeleteAsync(supplierProductId);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _supplierProductService.GetAllAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetActive")]
        public async Task<IActionResult> GetActive()
        {
            var result = await _supplierProductService.GetActiveAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetPassive")]
        public async Task<IActionResult> GetPassive()
        {
            var result = await _supplierProductService.GetPassiveAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }
    }
}
