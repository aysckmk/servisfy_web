using Microsoft.AspNetCore.Mvc;

namespace ServisFy.Controllers
{
    public class ServisController : Controller
    {
        public IActionResult Servis()
        {
            return View();
        }
    }
}
