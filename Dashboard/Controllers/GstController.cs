using Dashboard.Data;
using Dashboard.Models;
using Dashboard.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Dashboard.Controllers
{
    public class GstController : Controller
    {

        private readonly MVCDbContext mvcDbContext;

        public GstController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var gst = await mvcDbContext.gsts.ToListAsync();
            return View(gst);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddGst addGstRequest)
        {
            var gst = new Gst()
            {
                Id = addGstRequest.Id,
                Name = addGstRequest.Name
            };
            await mvcDbContext.gsts.AddAsync(gst);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Add");

        }


		[HttpGet]
		public async Task<IActionResult> View(int id)
		{
			var gst = await mvcDbContext.gsts.FirstOrDefaultAsync(x => x.Id == id);

			if (gst != null)
			{
				var viewModel = new AddGst()
				{
					Id = gst.Id,
					Name = gst.Name
				};
				return await Task.Run(() => View("View", (viewModel)));
			}

			return RedirectToAction("Index");
		}

        [HttpPost]
        public async Task<IActionResult> View(AddGst model)
        {
            var gst = await mvcDbContext.gsts.FindAsync(model.Id);
            if (gst != null)
            {
                gst.Name = model.Name;

                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(AddGst model)
        {
            var gst = await mvcDbContext.gsts.FindAsync(model.Id);

            if (gst != null)
            {
                mvcDbContext.gsts.Remove(gst);
                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }
}
