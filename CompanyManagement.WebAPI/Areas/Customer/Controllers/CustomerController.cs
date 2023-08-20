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
    }
}
