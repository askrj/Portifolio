using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portifolio.Services;
using Portifolio.ViewModels;

namespace Portifolio.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IProjetosService _projetoService;
        private readonly IEmailService _emailService;

        public PortfolioController(IProjetosService projetoService, 
            IEmailService emailService)
        {
            _projetoService = projetoService;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            var projetos = _projetoService.GetProjetos().Take(3).ToList();

            var modelo = new PortfolioViewModel()
            {
                Projetos = projetos
            };
            return View(modelo);
        }
        public IActionResult Projetos()
        {
            var projetos = _projetoService.GetProjetos();
            return View(projetos);
        }

        [HttpGet]
        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contato(ContatoViewModel contatoViewModel)
        {
            await _emailService.Enviar(contatoViewModel);
            return RedirectToAction("Obrigado");
        }

        public IActionResult Obrigado()
        {
            return View();
        }
    }
}