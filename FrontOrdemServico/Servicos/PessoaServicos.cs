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
    public class PessoaServicos
    {
        public static async Task<List<Pessoa>> GetPessoa()
        {
            List<Pessoa> lista = new List<Pessoa>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.GetAsync("Pessoa");

            if (response.IsSuccessStatusCode)
            {
                lista =
                    JsonConvert.DeserializeObject<List<Pessoa>>(
                    await response.Content.ReadAsStringAsync()
                    );
            }

            return lista;
        }

        public static async Task<string> PostPessoa(Pessoa Pessoa)
        {
            string retorno = "Erro ao cadastrar a pessoa";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            client.Timeout = new TimeSpan(0, 0, 30);

            HttpResponseMessage response = 
                await client.PostAsJsonAsync("Pessoa",Pessoa);

            if (response.IsSuccessStatusCode)
            {
                retorno = "Pessoa cadastrada";
            }

            return retorno;
        }

    }
}
