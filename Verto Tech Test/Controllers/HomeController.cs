using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Verto_Tech_Test.Data;


namespace Verto_Tech_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var pages = await dbContext.Pages.ToListAsync();

            return View(pages);
        }
    }
}
