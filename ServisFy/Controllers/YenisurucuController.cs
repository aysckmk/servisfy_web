using Microsoft.AspNetCore.Mvc;
using ServisFy.Models.Auth;

namespace ServisFy.Controllers
{
    public class YenisurucuController : Controller
    {
        public IActionResult Yenisurucu()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Yenisurucu(YeniSurucuDto yeniSurucu)
        {

            return RedirectToAction("Yonetim", "Yonetim");
        }
    }
}
