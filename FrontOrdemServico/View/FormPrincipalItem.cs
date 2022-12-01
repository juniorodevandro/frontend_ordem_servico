﻿using FrontOrdemServico.Modelo;
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
    public partial class FormPrincipalItem : FormularioController
    {
        private PaginacaoResponse<Item> paginacao = null;

        public FormPrincipalItem()
        {
            InitializeComponent();
            AtualizaTela();
        }

        private async void AtualizaTela()
        {
            this.paginacao = await ItemServicos.GetItem(int.Parse(paginaItem.Value.ToString()), int.Parse(qtdePaginaItem.Value.ToString()), textBoxPesquisaItem.Text);

            dataGridView.DataSource = paginacao.Dados;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightCyan;
                }
            }

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
            else
            {
                var form = new FormItem(dataGridView.CurrentRow.Cells, true);
                form.ShowDialog();
            }
        }

        private void buttonNovoItem_Click(object sender, EventArgs e)
        {
            var form = new FormItem();
            form.ShowDialog();

            AtualizaTela();
        }

        private void buttonAlterarItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
            else
            {
                var form = new FormItem(dataGridView.CurrentRow.Cells, true);
                form.ShowDialog();
            }

            AtualizaTela();
        }

        private async void buttonExcluirItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
            else
            {
                string item = dataGridView.CurrentRow.Cells[1].Value.ToString();

                DialogResult resposta = MessageBox.Show(null,
                                                        $"Deseja excluir o item {item}?",
                                                        "Excluir",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes)
                {
                    bool retorno = await ItemServicos.DeleteItem(item);

                    if (retorno)
                        MessageBox.Show("Item deletado com sucesso!");
                    else
                        MessageBox.Show("Erro ao deletar o item");
                }
            }

            AtualizaTela();
        }

        private void buttonPesquisaItem_Click(object sender, EventArgs e)
        {
            AtualizaTela();
        }

        private void buttonSairItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrimeiraItem_Click(object sender, EventArgs e)
        {
            paginaItem.Value = 1;
        }

        private void buttonAnteriorItem_Click(object sender, EventArgs e)
        {
            if (paginaItem.Value != 1)
                paginaItem.Value--;
        }

        private void paginaItem_ValueChanged(object sender, EventArgs e)
        {
            AtualizaTela();
        }

        private void buttonProximoItem_Click(object sender, EventArgs e)
        {
            var paginas = paginacao.TotalLinhas / paginacao.Take;

            int qtdePagina = (int)Math.Ceiling((decimal)paginas);

            if (paginacao.Skip < qtdePagina)
                paginaItem.Value++;
        }

        private void buttonUltimaItem_Click(object sender, EventArgs e)
        {
            decimal paginas = paginacao.TotalLinhas / paginacao.Take;

            int qtdePagina = (int)Math.Ceiling(paginas);

            paginaItem.Value = qtdePagina;
        }

        private void qtdePaginaItem_ValueChanged(object sender, EventArgs e)
        {
            AtualizaTela();
        }

        private void FormPrincipalItem_KeyDown(object sender, KeyEventArgs e)
        {
            FormController_KeyDown(sender, e);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}