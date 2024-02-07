using Dashboard.Data;
using Dashboard.Models;
using Dashboard.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public CategoryController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await mvcDbContext.categories.ToListAsync();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCategory addCategoryRequest)
        {
            var category = new Category()
            {
                Id = addCategoryRequest.Id,
                Name = addCategoryRequest.Name
            };
            await mvcDbContext.categories.AddAsync(category);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Add");

        }



        [HttpGet]
        public async Task<IActionResult> View(int id)
        {
            var category = await mvcDbContext.categories.FirstOrDefaultAsync(x => x.Id == id);

            if (category != null)
            {
                var viewModel = new AddCategory()
                {
                    Id = category.Id,
                    Name = category.Name
                };
                return await Task.Run(() => View("View", (viewModel)));
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> View(AddCategory model)
        {
            var category = await mvcDbContext.Brands.FindAsync(model.Id);
            if (category != null)
            {
                category.Name = model.Name;

                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

  //      [HttpPost]
		//public async Task<IActionResult> Delete(Category model)
		//{
		//	var category = await mvcDbContext.categories.FindAsync(model.Id);

		//	if (category != null)
		//	{
		//		mvcDbContext.categories.Remove(category);
		//		await mvcDbContext.SaveChangesAsync();

		//		return RedirectToAction("Index");
		//	}

		//	return RedirectToAction("Index");
		//}

		[HttpPost]
        public async Task<IActionResult> Delete(AddCategory model)
        {
            var category = await mvcDbContext.categories.FindAsync(model.Id);

            if (category != null)
            {
                mvcDbContext.categories.Remove(category);
                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail()
        {
            return View();
        }
    }
}
