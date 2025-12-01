using Microsoft.AspNetCore.Mvc;

namespace UrunStockTakip.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
