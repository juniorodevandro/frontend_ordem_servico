using FrontOrdemServico.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace FrontOrdemServico.Servicos
{
    public class ItemServicos
    {
        public static async Task<PaginacaoResponse<Item>> GetItem(int skip, int take, string? valor = "", bool itemDesc = true, int campoOrdenar = 1)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);

            string url = $"Item/Paginacao?skip={skip}&take={take}&itemDesc={itemDesc}&ordenar={campoOrdenar}";

            if (!String.IsNullOrEmpty(valor))
                url += $"&valor={valor}";

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {           
                var paginacaoResponse = JsonConvert.DeserializeObject<PaginacaoResponse<Item>>(await response.Content.ReadAsStringAsync());
               
                return paginacaoResponse;
            }
            else
                return null;            
        }

        public static async Task<bool> PostItem(Item Item)
        {            
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);

            HttpResponseMessage response = await client.PostAsJsonAsync("Item", Item);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Erro ao cadastrar o item" + await response.Content.ReadAsStringAsync());
                return false;
            }
            else
            {
                return true;
            }
        }

        public static async Task<bool> PutItem(Item Item)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);

            HttpResponseMessage response = await client.PutAsJsonAsync("Item", Item);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Erro ao alterar o item" + await response.Content.ReadAsStringAsync());
                return false;
            }
            else
            {
                return true;
            }
        }

        public static async Task<bool> DeleteItem(string codigoReferencia)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);

            string url = $"Item?codigoReferencia={codigoReferencia}";
            HttpResponseMessage response = await client.DeleteAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(await response.Content.ReadAsStringAsync());
                return false;
            }
            else
            {
                return true;
            }   
        }

    }
}
