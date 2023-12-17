using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.WebUI.Areas.ProductArea.Controllers
{
    [Area("product")]
    public class ProductAreaController : Controller
    {
        [HttpGet("{area}/{controller}/{action}")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("{area}/{controller}/{action}")]
        public IActionResult Create() 
        {
            return View();
        }
    }
}
