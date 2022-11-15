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
    public class ItemServicos
    {
        public static async Task<List<Item>> GetItem()
        {
            List<Item> lista = new List<Item>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7071/api/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.GetAsync("Item");

            if (response.IsSuccessStatusCode)
            {
                lista =
                    JsonConvert.DeserializeObject<List<Item>>(
                    await response.Content.ReadAsStringAsync()
                    );
            }

            return lista;
        }

        public static async Task<string> PostItem(Item Item)
        {
            string retorno = "Erro ao cadastrar Item";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7071/api/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            client.Timeout = new TimeSpan(0, 0, 30);

            HttpResponseMessage response = 
                await client.PostAsJsonAsync("Item", Item);

            if (response.IsSuccessStatusCode)
            {
                //retorno = await response.Content.ReadAsStringAsync();
                retorno = "Item cadastrado";
            }

            return retorno;
        }

    }
}
