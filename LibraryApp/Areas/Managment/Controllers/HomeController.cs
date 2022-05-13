using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Areas.Managment.Controllers
{
    [Area("Managment")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
 