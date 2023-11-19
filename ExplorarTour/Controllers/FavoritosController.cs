using ExplorarTour.DAL;
using ExplorarTour.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExplorarTour.Controllers
{
    public class FavoritosController : Controller
    {
        CardDAO dados = new CardDAO();
        public IActionResult Index()
        {
            ViewBag.listaCardFavorito = dados.getTodosCards().Where(x => x.favorito == 1);
            ViewBag.listaCardFavoritoCount = dados.getTodosCards().Where(x => x.favorito == 1).Count();
            return View();
        }

        [HttpGet]
        public IActionResult Favoritar(int id)
        {

            Card favoritaCard = new Card();

            ViewBag.cardAtualizar = dados.getTodosCards().Where(x => x.CAID == id).FirstOrDefault();
            if (ViewBag.cardAtualizar.favorito == 1)
            {
                favoritaCard.favorito = 0;
            }
            else
            {
                favoritaCard.favorito = 1;
            }




            favoritaCard.CAID = id;


            dados.favoritarCard(favoritaCard);

            return RedirectToAction("Index");
        }

    }
}
