using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontOrdemServico.Modelo
{
    public class Item
    {    
        public int Codigo { get; set; }
        public string CodigoReferencia { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string? Observacao { get; set; }

        override

        public string ToString()
        {
            return CodigoReferencia + " - " + Nome;
        }
    }
}
