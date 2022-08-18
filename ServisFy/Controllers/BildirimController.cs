using Microsoft.AspNetCore.Mvc;

namespace ServisFy.Controllers
{
    public class BildirimController : Controller
    {
        public IActionResult Bildirimler()
        {
            return View();
        }
    }
}
