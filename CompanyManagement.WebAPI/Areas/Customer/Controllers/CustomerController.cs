using Microsoft.AspNetCore.Authorization;

namespace CompanyManagement.WebAPI.Areas.Customer.Controllers
{
    [Area("Customer")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [Authorize]
        [HttpPost("api/[controller]/Create")]
        public async Task<IActionResult> Create(CustomerCreateDto customerCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Yanlış veri girişi yapıldı.");
            }

            var result = await _customerService.CreateAsync(customerCreateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpPut("api/[controller]/Update")]
        public async Task<IActionResult> Update(CustomerUpdateDto customerUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Yanlış veri girişi yapıldı.");
            }

            var result = await _customerService.UpdateAsync(customerUpdateDto);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpDelete("api/[controller]/Delete")]
        public async Task<IActionResult> Delete(Guid customerId)
        {
            var result = await _customerService.DeleteAsync(customerId);
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        //[Authorize]
        [HttpGet("api/[controller]/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _customerService.GetAllAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetActive")]
        public async Task<IActionResult> GetActive()
        {
            var result = await _customerService.GetActiveAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }

        [Authorize]
        [HttpGet("api/[controller]/GetPassive")]
        public async Task<IActionResult> GetPassive()
        {
            var result = await _customerService.GetPassiveAsync();
            return result.IsSuccess == true ? Ok(result) : BadRequest(result);
        }
    }
}
