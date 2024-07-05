using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Models
{
    public class Projeto
    {
        public int ProjetoId { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? ImagemURL { get; set; }
        public string? Link { get; set; }
    }
}