using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/Customer")]
    [Route("admin")]
    public class CustomerController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
