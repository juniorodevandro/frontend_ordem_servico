using FrontOrdemServico.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FrontOrdemServico.Servicos
{
    public class EstoqueServicos
    {
        public static async Task<List<Estoque>> GetEstoque()
        {
            List<Estoque> lista = new List<Estoque>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.GetAsync("Estoque");

            if (response.IsSuccessStatusCode)
            {
                lista = JsonConvert.DeserializeObject<List<Estoque>>(await response.Content.ReadAsStringAsync());
            }

            return lista;
        }

        public static async Task<bool> PostEstoque(Estoque Estoque)
        {
            string retorno = "Erro ao cadastrar o Estoque";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);

            HttpResponseMessage response = await client.PostAsJsonAsync("Estoque", Estoque);

            return response.IsSuccessStatusCode;
        }

    }
}
