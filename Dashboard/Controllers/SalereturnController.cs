using Dashboard.Data;
using Dashboard.Models;
using Dashboard.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Controllers
{
    public class SalereturnController : Controller
    {

        private readonly MVCDbContext mvcDbContext;

        public SalereturnController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }
        public IActionResult Index()

        {
            var items = mvcDbContext.Items
              .Select(item => item.ItemNameId).Distinct().ToList();
            ViewBag.items = items;
            return View();
        }

        [HttpPost]
        public IActionResult GetItemDetails(string itemNamePrefix)
        {
            var items = mvcDbContext.Items
                    .Where(item => item.ItemNameId.StartsWith(itemNamePrefix))
                   .ToList();

            return Json(items);
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
