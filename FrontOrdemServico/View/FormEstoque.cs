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

            string codigoReferencia = "";
            string quantidade = "0,00";
            
            AtualizarPermissaoFormulario(!prEditando);
            
            if (prRegistroSelecionado != null)
            {
                comboBoxEstado.Enabled = false;
                codigoReferencia = prRegistroSelecionado[0].Value.ToString();
                quantidade = prRegistroSelecionado[2].Value.ToString();
            }

            GetItemCombobox(codigoReferencia);
            textBoxQuantidade.Text = quantidade;
        }

        private void buttonCancelarEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void GetItemCombobox(string? prCodigoReferencia)
        {
           comboBoxEstado.DataSource = await ItemServicos.GetItem(prCodigoReferencia);

            if (comboBoxEstado.Enabled)
                comboBoxEstado.SelectedIndex = -1;
        }

        private async void SalvarEstque()
        {
            Item item = (Item)comboBoxEstado.SelectedItem;

            if (item == null)
            {
                MessageBox.Show("O item é obrigatório!");
            }
            else
            {
                Estoque estoque = new Estoque()
                {
                    quantidade = decimal.Parse(textBoxQuantidade.Text),
                    itemCodigoReferencia = item.CodigoReferencia,
                    itemNome = item.Nome
                };

                bool retorno = await EstoqueServicos.PostEstoque(estoque);

                if (retorno)
                {
                    MessageBox.Show("Estoque cadastrado/alterado com sucesso!");
                    this.Close();
                }           

            }
        }

        private void buttonSalvarEstoque_Click(object sender, EventArgs e)
        {
            SalvarEstque();
        }

        private void FormEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            FormController_KeyDown(sender, e);
        }

        private void textBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }

                //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                //{
                //    e.Handled = true;
                //}
            }
            catch
            {
                MessageBox.Show("Valor inválido");
            }
        }

        private void textBoxQuantidade_Click(object sender, EventArgs e)
        {
            textBox_Click(sender, e);
        }

        private void textBoxQuantidade_Leave(object sender, EventArgs e)
        {
            textBoxToCurrency(sender, e);
        }
    }
}
