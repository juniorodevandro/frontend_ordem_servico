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
    public partial class FormEstoque : FormularioController
    {
        public FormEstoque(DataGridViewCellCollection? prRegistroSelecionado = null, bool prEditando = false)
        {
            InitializeComponent();

            comboBoxEstado.Enabled = prRegistroSelecionado == null;

            GetItemCombobox(prRegistroSelecionado[0].Value.ToString(), prEditando);
        }

        private void buttonCancelarEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void GetItemCombobox(string? prCodigoReferencia, bool prEditando)
        {
           comboBoxEstado.DataSource = await ItemServicos.GetItem(prCodigoReferencia);
        }

        private async void SalvarEstque()
        {
            Item item = (Item)comboBoxEstado.SelectedItem;

            Estoque estoque = new Estoque()
            {
                quantidade = 1,
                itemCodigoReferencia = item.CodigoReferencia,
                itemNome = item.Nome
            };


            //estoque.itemCodigoReferencia = textBoxNome.Text;

            //estoque.quantidade = textBoxQuantidade.Text;

            bool retorno = await EstoqueServicos.PostEstoque(estoque);

            if (retorno)
            {
                MessageBox.Show("Item cadastrado com sucesso!");
                this.Close();
            }
        }

        private void buttonSalvarEstoque_Click(object sender, EventArgs e)
        {
            SalvarEstque();
        }
    }
}
