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
    public partial class FormPrincipalEstoque : Form
    {
        public FormPrincipalEstoque()
        {
            InitializeComponent();
            AtualizaTela();
        }

        private async void AtualizaTela()
        {
            List<Estoque> lista = await EstoqueServicos.GetEstoque();
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
                var form = new FormEstoque();
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
            var form = new FormEstoque();
            form.ShowDialog();
        }

        private void buttonAlterarEstoque_Click(object sender, EventArgs e)
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

        private void buttonSairEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
