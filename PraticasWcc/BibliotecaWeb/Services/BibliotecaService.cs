
using BibliotecaWeb.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BibliotecaWeb.Services
{
    public class BibliotecaService
    {
        private const string url = "https://itunes.apple.com/";
        

        public Response BuscaLivro(string textoPesquisa) 
        {
            string  parametros = $"search?term={textoPesquisa}&entity=ibook";
            var urlParam = $"{url}{parametros}";
           
            HttpClient clienteApi = new HttpClient();
            clienteApi.BaseAddress = new Uri(url);
            Response retorno = null;

            var resultado = clienteApi.GetAsync(urlParam).Result;
            if(resultado.IsSuccessStatusCode)
            {
                retorno = resultado.Content.ReadFromJsonAsync<Response>().Result;


            }
            clienteApi.Dispose();
            return retorno;

        }
        public Response BuscaLivroPeloId(int id)
        {
            string parametros = $"lookup?id={id}";
            var urlParam = $"{url}{parametros}";

            HttpClient clienteApi = new HttpClient();
            clienteApi.BaseAddress = new Uri(url);
            Response retorno = null;

            var resultado = clienteApi.GetAsync(urlParam).Result;
            if (resultado.IsSuccessStatusCode)
            {
                retorno = resultado.Content.ReadFromJsonAsync<Response>().Result;
            }
            clienteApi.Dispose();
            return retorno;

        }

    }
}
