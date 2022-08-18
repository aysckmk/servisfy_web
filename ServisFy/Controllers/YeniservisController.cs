using Microsoft.AspNetCore.Mvc;

namespace ServisFy.Controllers
{
    public class YeniservisController : Controller
    {
        public IActionResult New()
        {
            return View();
        }
    }
}
