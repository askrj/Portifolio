using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portifolio.ViewModels;

namespace Portifolio.Services
{
    public interface IEmailService
    {
        Task Enviar(ContatoViewModel contato);
    }
}