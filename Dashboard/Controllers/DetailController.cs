using BarcodeStandard;
using Dashboard.Data;
using Dashboard.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.DataClassification;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Controllers
{
    public class DetailController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public DetailController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }
        //[HttpGet]
        public IActionResult Index()
        {
            //var items = mvcDbContext.Items
            //   .Select(item => item.ItemNameId).Distinct().ToList();
            //ViewBag.items = items;

            return View();
        }


        [HttpPost]
        public IActionResult GetMatchingItemNames(string input)
        {
            // Implement logic to query items by input and return them as JSON
            var matchingItemNames = mvcDbContext.Items
                .Where(item => item.ItemNameId.StartsWith(input))
                .Select(item => item.ItemNameId)
                .ToList();

            return Json(matchingItemNames);
        }

        [HttpPost]
        public IActionResult GetItemDetails(string itemName)
        {
            // Implement logic to retrieve item details and return them as JSON
            var item = mvcDbContext.Items.FirstOrDefault(c => c.ItemNameId  == itemName);

            return Json(item);
        }

        //[HttpGet]
        //public JsonResult SearchItems(string searchTerm)
        //{
        //    var matchingItems = mvcDbContext.Items.Where(item => item.ItemNameId.Contains(searchTerm)).Select(item => item.ItemNameId);
        //    return Json(matchingItems);
        //}
        //[HttpPost]
        //public IActionResult GetItemDetails(string itemNamePrefix)
        //{
        //    var items = mvcDbContext.Items
        //            .Where(item => item.ItemNameId.StartsWith(itemNamePrefix))
        //           .ToList();

        //    return Json(items);
        //var items = mvcDbContext.Items
        //  .Where(item => item.ItemNameId.StartsWith(searchTerm))
        //  .Select(item => new
        //   {
        //       item.Id,
        //       item.ItemNameId,
        //       item.CategoryId,
        //       item.BrandId
        //   }).ToList();
        //return Json(items);

        //if (!string.IsNullOrEmpty(itemNamePrefix) && itemNamePrefix.Length >= 2)
        //{
        //    var items = mvcDbContext.Items
        //        .Where(item => item.ItemNameId.StartsWith(itemNamePrefix))
        //        .ToList();

        //    return Json(items);
        //}
        //else
        //{
        //    // Handle the case where no item is selected or typed
        //    return Json(new List<Item>());
        //}
        //}


        //var items = mvcDbContext.Items
        //    .Where(item => item.ItemNameId.StartsWith(itemNamePrefix))
        //    .ToList();


        //return Json(items);


        // Query the database to fetch item details based on itemName.

    }
    
}
    //[HttpPost]
    //public JsonResult GetItems(string term)
    //{
    //	var items = mvcDbContext.Items.Select(q => new
    //	{
    //		Name = q.ItemNameId,
    //		Id = q.Id
    //	}).Where(q => q.Name.Contains(term));
    //	return new JsonResult(items);
    //}

    //[HttpGet]
    //public IActionResult GetItemDetails(string partialItemName)
    //{
    //    // Query your data source to find items matching the partialItemName
    //    var matchingItems =  mvcDbContext.Items
    //        .Where(item => item.ItemNameId.ToLower().Contains(partialItemName.ToLower())).ToList();

    //    // Create an anonymous object with the necessary fields
    //    var result = matchingItems.Select(item => new
    //    {
    //        ItemName = item.ItemNameId,
    //        Quantity = item.ItemCodeId,
    //        Category = item.CategoryId,
    //        SalePrice = item.SalePriceId
    //    });

    //    return Json(result);
    //}
    //[HttpPost]
    //public JsonResult AutoComplete(string prefix)
    //{
    //    var items = (from item in this.mvcDbContext.Customers
    //                 where item.Name.StartsWith(prefix)
    //                 select new
    //                 {
    //                     //ItemNameId = item.ItemNameId
    //                     label = item.Name,
    //                     //label1 = item.CategoryId,
    //                     val = item.Id
    //                 }).ToList();

    //    return Json(items);
    //}

    //[HttpPost]
    //public ActionResult Index(string Name, string Id)
    //{
    //    ViewBag.Message = "ItemName: " + Name + " Id: " + Id ;
    //    return View();
    //}

   

