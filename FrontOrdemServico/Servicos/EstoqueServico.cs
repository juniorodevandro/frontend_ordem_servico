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
        public static async Task<List<Estoque>> GetEstoque(string prCodigoReferencia = "")
        {
            List<Estoque> lista = new List<Estoque>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);

            string url = "Estoque";

            if (!String.IsNullOrEmpty(prCodigoReferencia))
                url += "?codigoReferenciaItem=" + prCodigoReferencia;

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                lista = JsonConvert.DeserializeObject<List<Estoque>>(await response.Content.ReadAsStringAsync());
            }

            return lista;
        }

        public static async Task<bool> PostEstoque(Estoque Estoque)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);

            HttpResponseMessage response = await client.PostAsJsonAsync("Estoque", Estoque);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Erro ao cadastrar/alterar o estoque: " + await response.Content.ReadAsStringAsync());
                return false;
            }
            else
            {
                return true;
            }
        }

        public static async Task<bool> DeleteEstoque(string codigoReferencia)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);

            string url = $"Estoque?codigoReferencia={codigoReferencia}";
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
