using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/Register")]
    [Route("admin")]
    public class RegisterController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
