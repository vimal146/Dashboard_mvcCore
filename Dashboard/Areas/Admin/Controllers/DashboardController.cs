using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/Dashboard")]
    [Route("admin")]
    public class DashboardController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
