using Microsoft.AspNetCore.Mvc;

namespace ServisFy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
