using ExplorarTour.DAL;
using Microsoft.AspNetCore.Mvc;

namespace ExplorarTour.Controllers
{
    public class FavoritosController : Controller
    {
        CardDAO dados = new CardDAO();
        public IActionResult Index()
        {
            ViewBag.listaCardFavorito = dados.getTodosCards().Where(x => x.favorito == 1);
            return View();
        }
    }
}
