using Microsoft.AspNetCore.Mvc;

namespace ExplorarTour.Controllers
{
    public class DestinosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
