using Dashboard.Data;
using Dashboard.Models;
using Dashboard.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Controllers
{
    public class SaleController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public SaleController(MVCDbContext mvcDbContext)
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
        //public IActionResult ProcessForm(List<Item> items)
        //{

        //	foreach(var item in items)
        //	{
        //		mvcDbContext.Entry(item).State = EntityState.Modified;
        //	}
        //	mvcDbContext.SaveChanges();
        //	return RedirectToAction("Index");
        //}
        //[HttpGet]
        //public IActionResult GetItemDetails(string itemName,int itemId)
        //{
        //	var item = mvcDbContext.Items.FirstOrDefault(i => i.ItemNameId.StartsWith(itemName) && i.Id == itemId);

        //	if(item != null)
        //	{
        //		return Json(new { Total = item.SalePriceId, Price = item.PurchasePriceId });
        //	}
        //	return Json(null);
        //}


        //public IActionResult Add()
        //{
        //    var items = mvcDbContext.Items.ToList();
        //    ViewBag.Items = new SelectList(items, "Id", "ItemNameId");

        //    return View();
        //}

        //[HttpPost]
        //public JsonResult AutoComplete(string prefix)
        //{
        //    var items = (from item in mvcDbContext.Items
        //                 where item.ItemNameId.StartsWith(prefix)
        //                 select new
        //                 {
        //                     label = item.ItemNameId,
        //                     val = item.Id

        //                 }).ToList();
        //    return Json(items);
        //}

        //public async Task<IActionResult> Index()
        //{
        //    var items = await mvcDbContext.Items.ToListAsync();
        //    return View(items);
        //}

    }
}
