using Microsoft.AspNetCore.Mvc;


namespace Ventas.Wed.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
