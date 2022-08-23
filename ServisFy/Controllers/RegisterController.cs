using Microsoft.AspNetCore.Mvc;
using ServisFy.Models.Auth;

namespace ServisFy.Controllers
{
	public class RegisterController : Controller
	{
		public IActionResult Register()
		{
			return View();
		}

        [HttpPost]
		public IActionResult Register(RegisterDto register)
        {
			// Apiye yollama işlemleri vs.  Session Araştırılacak

			return RedirectToAction("Login", "Auth");
        }
	}
}
