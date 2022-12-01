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
    public partial class FormPrincipalEstoque : FormularioController
    {
        public FormPrincipalEstoque()
        {
            InitializeComponent();
            AtualizaTela();
        }

        private async void AtualizaTela()
        {
            List<Estoque> lista = await EstoqueServicos.GetEstoque(textBoxPesquisaEstoque.Text.Trim());

            dataGridViewEstoque.DataSource = lista;
        }

        private void dataGridViewEstoque_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewEstoque.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
            else
            {
                var form = new FormEstoque(dataGridViewEstoque.CurrentRow.Cells);
                form.ShowDialog();
            }
        }

        private void dataGridViewEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridViewEstoque.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridViewEstoque.Rows[i].DefaultCellStyle.BackColor = Color.LightCyan;
                }
            }

            foreach (DataGridViewColumn column in dataGridViewEstoque.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void buttonNovoEstoque_Click(object sender, EventArgs e)
        {
            var form = new FormEstoque(null, true);
            form.ShowDialog();

            AtualizaTela();
        }

        private void buttonAlterarEstoque_Click(object sender, EventArgs e)
        {
            if (dataGridViewEstoque.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
            else
            {
                var form = new FormEstoque(dataGridViewEstoque.CurrentRow.Cells, true);
                form.ShowDialog();    
            }

            AtualizaTela();
        }

        private void buttonSairEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipalEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxPesquisaEstoque.Focused)
            {
                buttonPesquisaEstoque_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F5)
            {
                AtualizaTela();
            }
        }

        private void buttonPesquisaEstoque_Click(object sender, EventArgs e)
        {
            AtualizaTela();
        }

        private async void buttonExcluirEstoque_Click(object sender, EventArgs e)
        {
            if (dataGridViewEstoque.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
            else
            {
                string codigoRefencia = dataGridViewEstoque.CurrentRow.Cells[0].Value.ToString();

                DialogResult resposta = MessageBox.Show(null,
                                                        $"Deseja excluir o estoque do item {codigoRefencia}?",
                                                        "Excluir",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes)
                {
                    bool retorno = await EstoqueServicos.DeleteEstoque(codigoRefencia);

                    if (retorno)
                        MessageBox.Show("Estoque deletado com sucesso!");
                    else
                        MessageBox.Show("Erro ao deletar o estoque");
                }
            }

            AtualizaTela();
        }
    }
}
