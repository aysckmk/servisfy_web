using Microsoft.AspNetCore.Mvc;
using ServisFy.Models.Auth;

namespace ServisFy.Controllers
{
    public class OkulController : Controller
    {
        public IActionResult Okul()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Okul(OkulDto okul)
        {
            // Apiye yollama işlemleri vs.  Session Araştırılacak

            return RedirectToAction("Yonetim", "Yonetim");
        }
    }
}
