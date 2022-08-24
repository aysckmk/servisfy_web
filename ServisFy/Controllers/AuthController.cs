using Microsoft.AspNetCore.Mvc;
using ServisFy.Models.Auth;

namespace ServisFy.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Login(LoginDto Login)
        {
            return RedirectToAction("Dash", "Dash");
        }
    }
}
