using Dashboard.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    public class SaleorderController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public SaleorderController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetItemNames(string input)
        {
            var itemNames = mvcDbContext.Items
                .Where(item => item.ItemNameId.Contains(input))
                .Select(item => item.ItemNameId)
                .ToList();

            return Json(itemNames);
        }

        [HttpPost]
        public IActionResult GetItemDetails(string selectedItem)
        {
            var item = mvcDbContext.Items
                .FirstOrDefault(item => item.ItemNameId == selectedItem);

            if (item != null)
            {
                return Json(item);
            }

            return Json(null);
        }
    }
}
