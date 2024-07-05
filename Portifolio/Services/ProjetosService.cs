using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portifolio.Models;

namespace Portifolio.Services
{
    public class ProjetosService : IProjetosService
    {
        public List<Projeto> GetProjetos()
        {
            return new List<Projeto>() {
                new Projeto
                {
                    Titulo = "Sistema de Vendas",
                    Descricao = "Sistema de controle de vendas criado em C#",
                    Link = "https://github.com/askrj/SistemaVendas",
                    ImagemURL = "/imagens/macorattinet11.jpg"
                },
                    new Projeto
                {
                    Titulo = "Eventus Laravel PHP",
                    Descricao = "Sistema de controle de eventus usando Laravel.",
                    Link = "https://github.com/askrj/Eventus-Laravel-PHP",
                    ImagemURL = "/imagens/cursomvc11.jpg"
                },
                    new Projeto
                {
                    Titulo = "Controle de vendedores",
                    Descricao = "Sistema de controle de vendedores e suas vendas usando C#, banco de dados Sql Server, Entity Framework",
                    Link = "https://github.com/askrj/sales",
                    ImagemURL = "/imagens/cursowebapi1.jpg"
                },
                    new Projeto
                {
                    Titulo = "Api Financeiro",
                    Descricao = "Api de controle financeiro sando C#, banco de dados Sql Server, Entity Framework.",
                    Link = "https://github.com/askrj/Fina",
                    ImagemURL = "/imagens/cursocleanarch11.jpg"
                },
                    new Projeto
                {
                    Titulo = "Novos projetos",
                    Descricao = "Os principais recursos do Blazor para criar aplicações web usando a linguagem C#",
                    Link = "https://github.com/askrj",
                    ImagemURL = "/imagens/cursoblazor11.jpg"
                },
                    new Projeto
                {
                    Titulo = "Novos projetos",
                    Descricao = "Usando o Docker em aplicações ASP .NET Core MVC",
                    Link = "https://github.com/askrj",
                    ImagemURL = "/imagens/cursodocker11.jpg"
                },
            };
        }
      }
    }
