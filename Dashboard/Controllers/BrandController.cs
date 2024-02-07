using Dashboard.Data;
using Dashboard.Models;
using Dashboard.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Controllers
{
    public class BrandController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public BrandController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var brand = await mvcDbContext.Brands.ToListAsync();
            return View(brand);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddBrand addBrandRequest)
        {
            var brand = new Brand()
            {
                Id = addBrandRequest.Id,
                Name = addBrandRequest.Name
            };
            await mvcDbContext.Brands.AddAsync(brand);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Add");

        }

        [HttpGet]
        public async Task<IActionResult> View(int id)
        {
            var brand = await mvcDbContext.Brands.FirstOrDefaultAsync(x => x.Id == id);

            if (brand != null)
            {
                var viewModel = new AddBrand()
                {
                    Id = brand.Id,
                    Name = brand.Name
                };
                return await Task.Run(() => View("View", (viewModel)));
            }

            return RedirectToAction("Index");
        }

		
		[HttpPost]
        public async Task<IActionResult> View(AddBrand model)
        {
            var brand = await mvcDbContext.Brands.FindAsync(model.Id);
            if (brand != null)
            {
                brand.Name = model.Name;

                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(AddBrand model)
        {
            var brand = await mvcDbContext.Brands.FindAsync(model.Id);

            if (brand != null)
            {
                mvcDbContext.Brands.Remove(brand);
                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

		
	}
}
