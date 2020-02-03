using Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;


namespace Atividade_1__etapa_2_.Controllers
{
    public class ConvidadoController : Controller
    {
        private readonly ILogger<ConvidadoController> _logger;

        public ConvidadoController(ILogger<ConvidadoController> logger)
        {
            _logger = logger;
        }

                public IActionResult Index ()
        {
            return View ();
        }

        [HttpPost]
        public IActionResult Create (Convidado convidado)
        {
            if(BaseDados.Incluir(convidado)) {
                return View("Success", convidado);
            }
            return View ("Failed", convidado);
        }
        public IActionResult List ()
        {
            List<Convidado> convidados = BaseDados.Listar();
            return View(convidados);
        }
    }
}
