using Dashboard.Data;
using Dashboard.Models.Domain;
using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Controllers
{
    public class UnitController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public UnitController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var unit = await mvcDbContext.Units.ToListAsync();
            return View(unit);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddUnit addUnitRequest)
        {
            var unit = new Unit()
            {
                Id = addUnitRequest.Id,
                Name = addUnitRequest.Name
            };
            await mvcDbContext.Units.AddAsync(unit);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Add");

        }

        [HttpGet]
        public async Task<IActionResult> View(int id)
        {
            var unit = await mvcDbContext.Units.FirstOrDefaultAsync(x => x.Id == id);

            if (unit != null)
            {
                var viewModel = new AddUnit()
                {
                    Id = unit.Id,
                    Name = unit.Name
                };
                return await Task.Run(() => View("View", (viewModel)));
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> View(AddUnit model)
        {
            var unit = await mvcDbContext.Units.FindAsync(model.Id);
            if (unit != null)
            {
                unit.Name = model.Name;

                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(AddUnit model)
        {
            var unit = await mvcDbContext.Units.FindAsync(model.Id);

            if (unit != null)
            {
                mvcDbContext.Units.Remove(unit);
                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }
}
