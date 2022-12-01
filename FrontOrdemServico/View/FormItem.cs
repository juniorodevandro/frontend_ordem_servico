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
    public partial class FormItem : FormularioController
    {
        bool Editando = false;

        public FormItem(DataGridViewCellCollection prRegistroSelecionado = null, bool prEditando = false, bool prVisualizando = false)
        {
            InitializeComponent();

            Editando = prEditando;

            if (prRegistroSelecionado != null)
            {                
                textBoxCodigo.Text = prRegistroSelecionado[0].Value.ToString();
                textBoxCodigoReferencia.Text = prRegistroSelecionado[1].Value.ToString();
                textBoxNome.Text = prRegistroSelecionado[2].Value.ToString();

                if (prRegistroSelecionado[3].Value != null)
                    textBoxTipo.Text = prRegistroSelecionado[3].Value.ToString();

                if (prRegistroSelecionado[4].Value != null)
                    textBoxObservacao.Text = prRegistroSelecionado[4].Value.ToString();

                textBoxCodigo.Enabled = !prEditando;
                textBoxCodigoReferencia.Enabled = !prEditando;

                if (prVisualizando)
                    AtualizarPermissaoFormulario(prVisualizando);
            }            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (this.Editando)
                SalvarEditando();
            else
                SalvarCadastrando();
        }

        private async void SalvarEditando()
        {
            Item item = new Item();
            item.Nome = textBoxNome.Text;
            item.CodigoReferencia = textBoxCodigoReferencia.Text;
            item.Tipo = textBoxTipo.Text;
            item.Observacao = textBoxObservacao.Text;

            bool retorno = await ItemServicos.PutItem(item);

            if (retorno)
            {
                MessageBox.Show("Item alterado com sucesso!");
                this.Close();
            }                
        }

        private async void SalvarCadastrando()
        {
            Item item = new Item();
            item.Nome = textBoxNome.Text;
            item.CodigoReferencia = textBoxCodigoReferencia.Text;
            item.Tipo = textBoxTipo.Text;
            item.Observacao = textBoxObservacao.Text;

            bool retorno = await ItemServicos.PostItem(item);

            if (retorno)
            {
                MessageBox.Show("Item cadastrado com sucesso!");
                this.Close();
            }            
        }

        private void FormItem_KeyDown(object sender, KeyEventArgs e)
        {
            FormController_KeyDown(sender, e);
        }
    }
}
