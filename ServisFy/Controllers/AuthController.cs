using Microsoft.AspNetCore.Mvc;

namespace ServisFy.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
