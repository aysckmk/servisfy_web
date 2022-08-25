using Microsoft.AspNetCore.Mvc;
using ServisFy.Models.Auth;

namespace ServisFy.Controllers
{
    public class YeniservisController : Controller
    {
        public IActionResult Yeniservis()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniServis(YeniServisDto yeniServis)
        {

            return RedirectToAction("Yonetim", "Yonetim");
        }
    }
}
