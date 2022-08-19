using Microsoft.AspNetCore.Mvc;

namespace ServisFy.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
