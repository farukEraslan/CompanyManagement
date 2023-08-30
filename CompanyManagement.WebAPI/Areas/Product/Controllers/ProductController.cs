namespace CompanyManagement.WebAPI.Areas.Product.Controllers
{
    [Area("Product")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [Authorize]
        [HttpPost("api/[controller]/Create")]
        public async Task<IActionResult> Create(ProductCreateDto productCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Yanlış veri girişi yapıldı.");
            }

            var result = await _productService.CreateAsync(productCreateDto);
            var productQRCode = await _productService.CreateQRCode(result.Data.Id);
            return result.IsSuccess == true ? File(productQRCode, "image/png") : BadRequest(result);
        }

        [Authorize]
        [HttpPut("api/[controller]/Update")]
        public async Task<IActionResult> Update(ProductUpdateDto productUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Yanlış veri girişi yapıldı.");
            }

            var result = await _productService.UpdateAsync(productUpdateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpDelete("api/[controller]/Delete")]
        public async Task<IActionResult> Delete(Guid productId)
        {
            var result = await _productService.DeleteAsync(productId);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [HttpGet("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAllAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [HttpGet("api/[controller]/GetById")]
        public async Task<IActionResult> GetById(Guid productId)
        {
            var result = await _productService.GetByIdAsync(productId);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetActive")]
        public async Task<IActionResult> GetActive()
        {
            var result = await _productService.GetActiveAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetPassive")]
        public async Task<IActionResult> GetPassive()
        {
            var result = await _productService.GetPassiveAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPost("api/[controller]/QRCodeCreate")]
        public async Task<IActionResult> QRCodeCreate(ProductQRCodeDto productQRCodeDto)
        {
            var qrCode = await _productService.CreateQRCode(productQRCodeDto.Id);
            return File(qrCode, "image/png");
        }
    }
}
