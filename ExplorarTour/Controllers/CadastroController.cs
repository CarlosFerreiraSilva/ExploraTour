using ExplorarTour.DAL;
using ExplorarTour.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExplorarTour.Controllers
{
    public class CadastroController : Controller
    {
        UsuarioDAO dados = new UsuarioDAO();

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.listaAluno = dados.getTodosAluno();
            return View();
        }

        [HttpPost]
        public IActionResult Create(string nome, string senha, string email)
        {


            Usuario novoAluno = new Usuario();

            novoAluno.Nome = nome;
            novoAluno.Senha = senha;
            novoAluno.Email = email;    
            novoAluno.DataCadastro = DateTime.Now;
            novoAluno.Perfil = "oi";
            novoAluno.LOGIN_ = "sim";

            dados.insertAluno(novoAluno);
            return RedirectToAction("Cadastrar");
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
