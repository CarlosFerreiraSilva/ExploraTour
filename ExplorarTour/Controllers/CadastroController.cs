using Microsoft.AspNetCore.Mvc;

namespace ExplorarTour.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
