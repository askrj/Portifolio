using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portifolio.Models;

namespace Portifolio.Services
{
    public interface IProjetosService
    {
        List<Projeto> GetProjetos();
    }
}