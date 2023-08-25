using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CompanyManagement.WebAPI.Areas.Product.Controllers
{
    [Area("Product")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
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
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
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

        [Authorize]
        [HttpGet("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAllAsync();
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

        //[Authorize]
        [HttpPost("api/[controller]/QRCodeCreate")]
        public async Task<IActionResult> QRCodeCreate(string data)
        {
            var qrCode = await _productService.CreateQRCode(data);
            return Ok(qrCode);
        }
    }
}
