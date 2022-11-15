using FrontOrdemServico.Modelo;
using FrontOrdemServico.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontOrdemServico.View
{
    public partial class FormPessoa : Form
    {
        public FormPessoa()
        {
            InitializeComponent();
            AtualizaTela();
        }

        private async void AtualizaTela()
        {
            List<Pessoa> lista = await PessoaServicos.GetPessoa();
            dataGridViewDados.DataSource = lista;
        }

        private async void buttonSalvar_Click(object sender, EventArgs e)
        {
            Pessoa Pessoa = new Pessoa();
            Pessoa.Nome = textBoxNome.Text;
            MessageBox.Show(await PessoaServicos.PostPessoa(Pessoa));
        }
    }
}
