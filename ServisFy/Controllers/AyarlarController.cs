using Microsoft.AspNetCore.Mvc;
using ServisFy.Models.Auth;

namespace ServisFy.Controllers
{
    public class AyarlarController : Controller
    {
        public IActionResult Ayarlar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ayarlar(AyarlarDto ayarlar)
        {
            // Apiye yollama işlemleri vs.  Session Araştırılacak

            return RedirectToAction("Dash", "Dash");
        }
    }
}
