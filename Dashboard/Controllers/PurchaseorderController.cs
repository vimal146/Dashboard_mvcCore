using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    public class PurchaseorderController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
