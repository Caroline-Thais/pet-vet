using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Segunda_Atividade.Models;

namespace Segunda_Atividade.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
            [HttpPost]
            public IActionResult Cadastro(Agendamento agendamento)
            {
                BancoDados.Incluir(agendamento);
                return View("Concluido");
            }
            public IActionResult Listagem()
            {
                List<Agendamento> agendamentos = BancoDados.Listar();
                return View(agendamentos);
            }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
