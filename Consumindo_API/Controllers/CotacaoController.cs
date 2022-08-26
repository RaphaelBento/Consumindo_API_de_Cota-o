using Consumindo_API.AcessoApi;
using Consumindo_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consumindo_API.Controllers
{
    public class CotacaoController : Controller
    {
        AcessDadosApi acessDadosApi = new AcessDadosApi();
        public IActionResult CotacaoDolar() 
        {
            USDBRLModel Dolar = acessDadosApi.GetTask().Result.USDBRL;
            return View(Dolar);
        }

        public IActionResult CotacaoEuro()
        {
            EURBRLModel Euro = acessDadosApi.GetTask().Result.EURBRL;
            return View(Euro);
        }

    }
}
