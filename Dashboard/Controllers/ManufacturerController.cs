using Dashboard.Data;
using Dashboard.Models;
using Dashboard.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Controllers
{
    public class ManufacturerController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public ManufacturerController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var manufacturer = await mvcDbContext.Manufacturers.ToListAsync();
            return View(manufacturer);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddManufacturer addManufactureRequest)
        {
            var manufacturer = new Manufacturer()
            {
                Id = addManufactureRequest.Id,
                Name = addManufactureRequest.Name
            };
            await mvcDbContext.Manufacturers.AddAsync(manufacturer);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Add");

        }

        [HttpGet]
        public async Task<IActionResult> View(int id)
        {
            var manufacturer = await mvcDbContext.Manufacturers.FirstOrDefaultAsync(x => x.Id == id);

            if (manufacturer != null)
            {
                var viewModel = new AddManufacturer()
                {
                    Id = manufacturer.Id,
                    Name = manufacturer.Name
                };
                return await Task.Run(() => View("View", (viewModel)));
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> View(AddManufacturer model)
        {
            var manufacturer = await mvcDbContext.Manufacturers.FindAsync(model.Id);
            if (manufacturer != null)
            {
                manufacturer.Name = model.Name;

                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(AddManufacturer model)
        {
            var manufacturer = await mvcDbContext.Manufacturers.FindAsync(model.Id);

            if (manufacturer != null)
            {
                mvcDbContext.Manufacturers.Remove(manufacturer);
                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
