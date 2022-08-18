using Microsoft.AspNetCore.Mvc;

namespace ServisFy.Controllers
{
    public class DashController : Controller
    {
        public IActionResult Dash()
        {
            return View();
        }
    }
}
