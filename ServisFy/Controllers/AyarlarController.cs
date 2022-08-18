using Microsoft.AspNetCore.Mvc;

namespace ServisFy.Controllers
{
    public class AyarlarController : Controller
    {
        public IActionResult Ayarlar()
        {
            return View();
        }
    }
}
