using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System;
using Dashboard.Data;
using Dashboard.Models.Domain;
using Dashboard.Models;
using System.Runtime.Intrinsics.Arm;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dashboard.Controllers
{
    public class ItemController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public   ItemController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var items = await mvcDbContext.Items.ToListAsync();
            return View(items);
        }
        //public IActionResult Add()
        //{
        //    var categories = mvcDbContext.categories.ToList();
        //    var addItemModel = new AddItem
        //    {
        //        Categories = categories
        //    };
        //    return View(addItemModel);
        //}
        

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
            
        [HttpPost]
        public async Task<IActionResult> Add(AddItem addItemRequest)
        {
            var item = new Item()
            {
                Id = addItemRequest.Id,
                ItemNameId = addItemRequest.ItemNameId,
                ItemCodeId = addItemRequest.ItemCodeId,
                CategoryId = addItemRequest.CategoryId,
                ManufacturerId = addItemRequest.ManufacturerId,
                BrandId = addItemRequest.BrandId,
                GSTId = addItemRequest.GSTId,
                UnitId = addItemRequest.UnitId,
                HSNCode = addItemRequest.HSNCode,
                BatchId = addItemRequest.BatchId,
                MRPId = addItemRequest.MRPId,
                PurchasePriceId = addItemRequest.PurchasePriceId,
                LandingCostId = addItemRequest.LandingCostId,
                SalePriceId = addItemRequest.SalePriceId,
                SalesDiscount = addItemRequest.SalesDiscount,
                OpeningQuantity = addItemRequest.OpeningQuantity,
                RackColor = addItemRequest.RackColor,
                ColorCode = addItemRequest.ColorCode,
                QuantityWarning = addItemRequest.QuantityWarning,
                IMEnumber = addItemRequest.IMEnumber,
                ItemManuDate = addItemRequest.ItemManuDate,
                ItemPackedDate = addItemRequest.ItemPackedDate,
                ItemExpiryDate = addItemRequest.ItemExpiryDate,
                ItemIssuedDate = addItemRequest.ItemIssuedDate,
                Discription = addItemRequest.Discription

            };

            await mvcDbContext.Items.AddAsync(item);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }
        public async Task<IActionResult> View(int id)
        {
            var item = await mvcDbContext.Items.FirstOrDefaultAsync(x => x.Id == id);

            if (item != null)
            {
                var viewModel = new AddItem()
                {
                    Id = item.Id,
                    ItemNameId = item.ItemNameId,
                    ItemCodeId = item.ItemCodeId,
                    CategoryId = item.CategoryId,
                    ManufacturerId = item.ManufacturerId,
                    BrandId = item.BrandId,
                    GSTId = item.GSTId,
                    UnitId = item.UnitId,
                    HSNCode = item.HSNCode,
                    BatchId = item.BatchId,
                    MRPId = item.MRPId,
                    PurchasePriceId = item.PurchasePriceId,
                    LandingCostId = item.LandingCostId,
                    SalePriceId = item.SalePriceId,
                    SalesDiscount = item.SalesDiscount,
                    OpeningQuantity = item.OpeningQuantity,
                    RackColor = item.RackColor,
                    ColorCode = item.ColorCode,
                    QuantityWarning = item.QuantityWarning,
                    IMEnumber = item.IMEnumber,
                    ItemManuDate = item.ItemManuDate,
                    ItemPackedDate = item.ItemPackedDate,
                    ItemExpiryDate = item.ItemExpiryDate,
                    ItemIssuedDate = item.ItemIssuedDate,
                    Discription = item.Discription

                };
                return await Task.Run(() => View("View", (viewModel)));
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> View(AddItem model)
        {
            var item = await mvcDbContext.Items.FindAsync(model.Id);
            if (item != null)
            {
                item.ItemNameId = model.ItemNameId;
                item.ItemCodeId = model.ItemCodeId;
                item.CategoryId = model.CategoryId;
                item.BrandId = model.BrandId;
                item.GSTId = model.GSTId;
                item.UnitId = model.UnitId;
                item.HSNCode = model.HSNCode;
                item.BatchId = model.BatchId;
                item.MRPId = model.MRPId;
                item.PurchasePriceId = model.PurchasePriceId;
                item.LandingCostId = model.LandingCostId;
                item.SalePriceId = model.SalePriceId;
                item.SalesDiscount = model.SalesDiscount;
                item.OpeningQuantity = model.OpeningQuantity;
                item.RackColor = model.RackColor;
                item.ColorCode = model.ColorCode;
                item.QuantityWarning = model.QuantityWarning;
                item.IMEnumber = model.IMEnumber;
                item.ItemManuDate = model.ItemManuDate;
                item.ItemPackedDate = model.ItemPackedDate;
                item.ItemExpiryDate = model.ItemExpiryDate;
                item.ItemIssuedDate = model.ItemIssuedDate;
                item.Discription = model.Discription;


                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(AddItem model)
        {
            var item = await mvcDbContext.Items.FindAsync(model.Id);

            if (item != null)
            {
                mvcDbContext.Items.Remove(item);
                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

       
        //[HttpPost]
        //public JsonResult AutoComplete(string query)
        //{
        //    var items = (from item in mvcDbContext.Items
        //                 where item.ItemNameId.StartsWith(query)
        //                 select new
        //                 {
        //                     label = item.ItemNameId,
        //                     val = item.ItemNameId

        //                 }).ToList();
        //    return Json(items);
        //}
    }
}
