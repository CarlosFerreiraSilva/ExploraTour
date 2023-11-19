using ExplorarTour.DAL;
using ExplorarTour.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExplorarTour.Controllers
{
    public class DestinosController : Controller
    {
        CardDAO dados = new CardDAO();
        public IActionResult Index()
        {
            ViewBag.listaCard = dados.getTodosCards();
            return View();
        }

        [HttpGet]
        public IActionResult Criacao()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Descricao(int id)
        {
            ViewBag.cardAtualizar = dados.getTodosCards().Where(x => x.CAID == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public IActionResult Create(string nome, string descricaop, string descricaog)
        {


            Card novoCard = new Card();

            novoCard.CANome = nome;
            novoCard.CADescricaoP = descricaop;
            novoCard.CADescricaoG = descricaog;
            novoCard.CAData = DateTime.Now;


            dados.insertCard(novoCard);
            return RedirectToAction("Index");
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
