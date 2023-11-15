using Microsoft.AspNetCore.Mvc;

namespace ExplorarTour.Controllers
{
    public class FavoritosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
