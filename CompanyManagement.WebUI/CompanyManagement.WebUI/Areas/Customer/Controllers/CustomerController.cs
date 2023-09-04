using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.WebUI.Areas.Customer.Controllers
{
    [Area("customer")]
    public class CustomerController : Controller
    {
        [Route("{area}/list")]
        public IActionResult GetAllCustomer()
        {
            return View();
        }

        [Route("{area}/create")]
        public IActionResult CreateCustomer()
        {
            return View();
        }

        [Route("{area}/update")]
        public IActionResult UpdateCustomer()
        {
            return View();
        }

        [Route("{area}/delete")]
        public IActionResult DeleteCustomer()
        {
            return View();
        }
    }
}
