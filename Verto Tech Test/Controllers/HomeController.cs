using Microsoft.AspNetCore.Mvc;

namespace Verto_Tech_Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
