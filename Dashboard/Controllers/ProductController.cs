using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    //[Area("admin")]
    //[Route("admin/Customer")]
    //[Route("admin")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
