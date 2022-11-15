using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontOrdemServico.Modelo
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string? Tipo { get; set; }
        public string? Contato { get; set; }
        public string? Endereco { get; set; }
    }
}
