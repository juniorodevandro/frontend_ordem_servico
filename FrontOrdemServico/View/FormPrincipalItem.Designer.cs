namespace FrontOrdemServico.View
{
    partial class FormPrincipalItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExcluirItem = new System.Windows.Forms.Button();
            this.buttonAlterarItem = new System.Windows.Forms.Button();
            this.buttonNovoItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonPesquisaItem = new System.Windows.Forms.Button();
            this.textBoxPesquisaItem = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSairItem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBoxOrdenacaoItem = new System.Windows.Forms.ComboBox();
            this.qtdePaginaItem = new System.Windows.Forms.NumericUpDown();
            this.paginaItem = new System.Windows.Forms.NumericUpDown();
            this.buttonPrimeiraItem = new System.Windows.Forms.Button();
            this.buttonAnteriorItem = new System.Windows.Forms.Button();
            this.buttonProximoItem = new System.Windows.Forms.Button();
            this.buttonUltimaItem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdePaginaItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginaItem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExcluirItem
            // 
            this.buttonExcluirItem.Image = global::FrontOrdemServico.Properties.Resources.Excluir32X32;
            this.buttonExcluirItem.Location = new System.Drawing.Point(216, 7);
            this.buttonExcluirItem.Name = "buttonExcluirItem";
            this.buttonExcluirItem.Size = new System.Drawing.Size(99, 40);
            this.buttonExcluirItem.TabIndex = 3;
            this.buttonExcluirItem.Text = "Excluir";
            this.buttonExcluirItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExcluirItem.UseVisualStyleBackColor = true;
            this.buttonExcluirItem.Click += new System.EventHandler(this.buttonExcluirItem_Click);
            // 
            // buttonAlterarItem
            // 
            this.buttonAlterarItem.Image = global::FrontOrdemServico.Properties.Resources.Editar32X32;
            this.buttonAlterarItem.Location = new System.Drawing.Point(111, 8);
            this.buttonAlterarItem.Name = "buttonAlterarItem";
            this.buttonAlterarItem.Size = new System.Drawing.Size(99, 40);
            this.buttonAlterarItem.TabIndex = 2;
            this.buttonAlterarItem.Text = "Alterar";
            this.buttonAlterarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAlterarItem.UseVisualStyleBackColor = true;
            this.buttonAlterarItem.Click += new System.EventHandler(this.buttonAlterarItem_Click);
            // 
            // buttonNovoItem
            // 
            this.buttonNovoItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNovoItem.Image = global::FrontOrdemServico.Properties.Resources.Novo32X32;
            this.buttonNovoItem.Location = new System.Drawing.Point(6, 7);
            this.buttonNovoItem.Name = "buttonNovoItem";
            this.buttonNovoItem.Size = new System.Drawing.Size(99, 40);
            this.buttonNovoItem.TabIndex = 1;
            this.buttonNovoItem.Text = "Novo";
            this.buttonNovoItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNovoItem.UseVisualStyleBackColor = true;
            this.buttonNovoItem.Click += new System.EventHandler(this.buttonNovoItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 51);
            this.panel1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonPesquisaItem);
            this.panel6.Controls.Add(this.textBoxPesquisaItem);
            this.panel6.Location = new System.Drawing.Point(321, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(773, 50);
            this.panel6.TabIndex = 2;
            // 
            // buttonPesquisaItem
            // 
            this.buttonPesquisaItem.Image = global::FrontOrdemServico.Properties.Resources.Lupa32X32;
            this.buttonPesquisaItem.Location = new System.Drawing.Point(668, 7);
            this.buttonPesquisaItem.Name = "buttonPesquisaItem";
            this.buttonPesquisaItem.Size = new System.Drawing.Size(99, 40);
            this.buttonPesquisaItem.TabIndex = 5;
            this.buttonPesquisaItem.Text = "Pesquisar";
            this.buttonPesquisaItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPesquisaItem.UseVisualStyleBackColor = true;
            this.buttonPesquisaItem.Click += new System.EventHandler(this.buttonPesquisaItem_Click);
            // 
            // textBoxPesquisaItem
            // 
            this.textBoxPesquisaItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPesquisaItem.Location = new System.Drawing.Point(8, 9);
            this.textBoxPesquisaItem.Name = "textBoxPesquisaItem";
            this.textBoxPesquisaItem.Size = new System.Drawing.Size(654, 36);
            this.textBoxPesquisaItem.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonSairItem);
            this.panel5.Location = new System.Drawing.Point(1094, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 50);
            this.panel5.TabIndex = 1;
            // 
            // buttonSairItem
            // 
            this.buttonSairItem.Image = global::FrontOrdemServico.Properties.Resources.Sair32X32;
            this.buttonSairItem.Location = new System.Drawing.Point(6, 7);
            this.buttonSairItem.Name = "buttonSairItem";
            this.buttonSairItem.Size = new System.Drawing.Size(84, 40);
            this.buttonSairItem.TabIndex = 6;
            this.buttonSairItem.Text = "Sair";
            this.buttonSairItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSairItem.UseVisualStyleBackColor = true;
            this.buttonSairItem.Click += new System.EventHandler(this.buttonSairItem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonExcluirItem);
            this.panel4.Controls.Add(this.buttonAlterarItem);
            this.panel4.Controls.Add(this.buttonNovoItem);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 50);
            this.panel4.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.comboBoxOrdenacaoItem);
            this.panel7.Controls.Add(this.qtdePaginaItem);
            this.panel7.Controls.Add(this.paginaItem);
            this.panel7.Controls.Add(this.buttonPrimeiraItem);
            this.panel7.Controls.Add(this.buttonAnteriorItem);
            this.panel7.Controls.Add(this.buttonProximoItem);
            this.panel7.Controls.Add(this.buttonUltimaItem);
            this.panel7.Location = new System.Drawing.Point(0, 403);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1190, 54);
            this.panel7.TabIndex = 0;
            // 
            // comboBoxOrdenacaoItem
            // 
            this.comboBoxOrdenacaoItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOrdenacaoItem.FormattingEnabled = true;
            this.comboBoxOrdenacaoItem.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.comboBoxOrdenacaoItem.Location = new System.Drawing.Point(575, 9);
            this.comboBoxOrdenacaoItem.Name = "comboBoxOrdenacaoItem";
            this.comboBoxOrdenacaoItem.Size = new System.Drawing.Size(145, 36);
            this.comboBoxOrdenacaoItem.TabIndex = 13;
            // 
            // qtdePaginaItem
            // 
            this.qtdePaginaItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qtdePaginaItem.Location = new System.Drawing.Point(504, 10);
            this.qtdePaginaItem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtdePaginaItem.Name = "qtdePaginaItem";
            this.qtdePaginaItem.Size = new System.Drawing.Size(65, 34);
            this.qtdePaginaItem.TabIndex = 12;
            this.qtdePaginaItem.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.qtdePaginaItem.ValueChanged += new System.EventHandler(this.qtdePaginaItem_ValueChanged);
            // 
            // paginaItem
            // 
            this.paginaItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paginaItem.Location = new System.Drawing.Point(216, 11);
            this.paginaItem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.paginaItem.Name = "paginaItem";
            this.paginaItem.Size = new System.Drawing.Size(65, 34);
            this.paginaItem.TabIndex = 9;
            this.paginaItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.paginaItem.ValueChanged += new System.EventHandler(this.paginaItem_ValueChanged);
            // 
            // buttonPrimeiraItem
            // 
            this.buttonPrimeiraItem.Image = global::FrontOrdemServico.Properties.Resources.SetaPrimeira32X32;
            this.buttonPrimeiraItem.Location = new System.Drawing.Point(6, 7);
            this.buttonPrimeiraItem.Name = "buttonPrimeiraItem";
            this.buttonPrimeiraItem.Size = new System.Drawing.Size(99, 40);
            this.buttonPrimeiraItem.TabIndex = 7;
            this.buttonPrimeiraItem.Text = "Primeira";
            this.buttonPrimeiraItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPrimeiraItem.UseVisualStyleBackColor = true;
            this.buttonPrimeiraItem.Click += new System.EventHandler(this.buttonPrimeiraItem_Click);
            // 
            // buttonAnteriorItem
            // 
            this.buttonAnteriorItem.Image = global::FrontOrdemServico.Properties.Resources.SetaAnterior32X32;
            this.buttonAnteriorItem.Location = new System.Drawing.Point(111, 7);
            this.buttonAnteriorItem.Name = "buttonAnteriorItem";
            this.buttonAnteriorItem.Size = new System.Drawing.Size(99, 40);
            this.buttonAnteriorItem.TabIndex = 8;
            this.buttonAnteriorItem.Text = "Anterior";
            this.buttonAnteriorItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAnteriorItem.UseVisualStyleBackColor = true;
            this.buttonAnteriorItem.Click += new System.EventHandler(this.buttonAnteriorItem_Click);
            // 
            // buttonProximoItem
            // 
            this.buttonProximoItem.Image = global::FrontOrdemServico.Properties.Resources.Setaproxima32X32;
            this.buttonProximoItem.Location = new System.Drawing.Point(291, 7);
            this.buttonProximoItem.Name = "buttonProximoItem";
            this.buttonProximoItem.Size = new System.Drawing.Size(99, 40);
            this.buttonProximoItem.TabIndex = 10;
            this.buttonProximoItem.Text = "Próximo";
            this.buttonProximoItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProximoItem.UseVisualStyleBackColor = true;
            this.buttonProximoItem.Click += new System.EventHandler(this.buttonProximoItem_Click);
            // 
            // buttonUltimaItem
            // 
            this.buttonUltimaItem.Image = global::FrontOrdemServico.Properties.Resources.SetaUltima32X32;
            this.buttonUltimaItem.Location = new System.Drawing.Point(399, 7);
            this.buttonUltimaItem.Name = "buttonUltimaItem";
            this.buttonUltimaItem.Size = new System.Drawing.Size(99, 40);
            this.buttonUltimaItem.TabIndex = 11;
            this.buttonUltimaItem.Text = "Última";
            this.buttonUltimaItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUltimaItem.UseVisualStyleBackColor = true;
            this.buttonUltimaItem.Click += new System.EventHandler(this.buttonUltimaItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 351);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1190, 351);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // Código
            // 
            this.Código.DataPropertyName = "codigo";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // FormPrincipalItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipalItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipalItem_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qtdePaginaItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginaItem)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonExcluirItem;
        private Button buttonAlterarItem;
        private Button buttonNovoItem;
        private Panel panel3;
        private Panel panel1;
        private Panel panel6;
        private Button buttonPesquisaItem;
        private TextBox textBoxPesquisaItem;
        private Panel panel5;
        private Button buttonSairItem;
        private Panel panel4;
        private DataGridView dataGridViewItem;
        private Panel panel7;
        private NumericUpDown qtdePaginaItem;
        private NumericUpDown paginaItem;
        private Button buttonPrimeiraItem;
        private Button buttonAnteriorItem;
        private Button buttonProximoItem;
        private Button buttonUltimaItem;
        private Panel panel2;
        private DataGridView dataGridView;
        private ComboBox comboBoxOrdenacaoItem;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}