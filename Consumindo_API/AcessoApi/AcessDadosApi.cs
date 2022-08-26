using Consumindo_API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Consumindo_API.AcessoApi
{
    public class AcessDadosApi
    {
        HttpClient clientAwesome = new HttpClient();

        public AcessDadosApi()
        {
        
            clientAwesome.BaseAddress = new Uri("https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL");
            clientAwesome.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

        public async Task<RaizCotacaoModel> GetTask() 
        {
            var responseAwesome = await clientAwesome.GetAsync("");
            var clienterespostaAwesome = await responseAwesome.Content.ReadAsStringAsync();

            var informacaoesAwesome = JsonConvert.DeserializeObject<RaizCotacaoModel>(clienterespostaAwesome);

            return informacaoesAwesome;
            
        }
    }
}
