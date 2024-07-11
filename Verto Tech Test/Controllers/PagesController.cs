using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Verto_Tech_Test.Data;
using Verto_Tech_Test.Models;

namespace Verto_Tech_Test.Controllers
{
    public class PagesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public PagesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Cms()
        {
            var pages = await dbContext.Pages.ToListAsync();

            return View(pages);
        }

        [HttpGet]
        public async Task<IActionResult> ViewPage(Guid id)
        {
            var page = await dbContext.Pages.FindAsync(id);

            if(page != null)
            {
                var viewModel = new UpdatePageViewModel()
                {
                    Id = page.Id,
                    Title = page.Title,
                    ImageUrl = page.ImageUrl,
                    Description = page.Description
                };
                return await Task.Run(() => View("ViewPage", viewModel));
            }            
            return RedirectToAction("Cms");
        }

        [HttpPost]
        public async Task<IActionResult> ViewPage(UpdatePageViewModel model)
        {
            var page = await dbContext.Pages.FindAsync(model.Id);

            if (page != null)
            {
                page.Title = model.Title;
                page.ImageUrl = model.ImageUrl;
                page.Description = model.Description;

                await dbContext.SaveChangesAsync();

                return RedirectToAction("Cms");
            }

            return RedirectToAction("Cms");
        }

    }
}
