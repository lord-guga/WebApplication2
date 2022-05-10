using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EquipeController : Controller
    {
        // ActionResult representa diversos códigos HTTP
        // Códigos HTTP - link do chat que o professor mandou

        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            // ViewBag = Reserva de espaço para armazenar informações para recuperar na VIEW
            // ViewBag = Tem a função de carregar as informações da Controller para a VIEW
            ViewBag.Equipes = equipeModel.LerEquipes();

            return View();
        }
    }
}
