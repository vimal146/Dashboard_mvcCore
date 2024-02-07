using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
