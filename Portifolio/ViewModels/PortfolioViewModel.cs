using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portifolio.Models;

namespace Portifolio.ViewModels
{
    public class PortfolioViewModel
    {
        public IEnumerable<Projeto>? Projetos { get; set; }
    }
}