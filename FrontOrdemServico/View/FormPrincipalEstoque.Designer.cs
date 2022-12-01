namespace FrontOrdemServico.View
{
    partial class FormPrincipalEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalEstoque));
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.CodigoItem_Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeItem_Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonExcluirEstoque = new System.Windows.Forms.Button();
            this.buttonAlterarEstoque = new System.Windows.Forms.Button();
            this.buttonNovoEstoque = new System.Windows.Forms.Button();
            this.buttonSairEstoque = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonPesquisaEstoque = new System.Windows.Forms.Button();
            this.textBoxPesquisaEstoque = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Código
            // 
            this.Código.DataPropertyName = "codigo";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.AllowUserToAddRows = false;
            this.dataGridViewEstoque.AllowUserToDeleteRows = false;
            this.dataGridViewEstoque.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoItem_Estoque,
            this.nomeItem_Estoque,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewEstoque.Location = new System.Drawing.Point(6, 0);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.ReadOnly = true;
            this.dataGridViewEstoque.RowTemplate.Height = 25;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(1178, 400);
            this.dataGridViewEstoque.TabIndex = 0;
            this.dataGridViewEstoque.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewEstoque_CellFormatting);
            this.dataGridViewEstoque.DoubleClick += new System.EventHandler(this.dataGridViewEstoque_DoubleClick);
            // 
            // CodigoItem_Estoque
            // 
            this.CodigoItem_Estoque.DataPropertyName = "itemCodigoReferencia";
            this.CodigoItem_Estoque.HeaderText = "Código de referência";
            this.CodigoItem_Estoque.Name = "CodigoItem_Estoque";
            this.CodigoItem_Estoque.ReadOnly = true;
            this.CodigoItem_Estoque.Width = 200;
            // 
            // nomeItem_Estoque
            // 
            this.nomeItem_Estoque.DataPropertyName = "itemNome";
            this.nomeItem_Estoque.HeaderText = "Nome";
            this.nomeItem_Estoque.Name = "nomeItem_Estoque";
            this.nomeItem_Estoque.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "quantidade";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewEstoque);
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 403);
            this.panel2.TabIndex = 7;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonExcluirEstoque);
            this.panel4.Controls.Add(this.buttonAlterarEstoque);
            this.panel4.Controls.Add(this.buttonNovoEstoque);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 50);
            this.panel4.TabIndex = 0;
            // 
            // buttonExcluirEstoque
            // 
            this.buttonExcluirEstoque.Image = global::FrontOrdemServico.Properties.Resources.Excluir32X32;
            this.buttonExcluirEstoque.Location = new System.Drawing.Point(216, 7);
            this.buttonExcluirEstoque.Name = "buttonExcluirEstoque";
            this.buttonExcluirEstoque.Size = new System.Drawing.Size(99, 40);
            this.buttonExcluirEstoque.TabIndex = 4;
            this.buttonExcluirEstoque.Text = "Excluir";
            this.buttonExcluirEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExcluirEstoque.UseVisualStyleBackColor = true;
            this.buttonExcluirEstoque.Click += new System.EventHandler(this.buttonExcluirEstoque_Click);
            // 
            // buttonAlterarEstoque
            // 
            this.buttonAlterarEstoque.Image = global::FrontOrdemServico.Properties.Resources.Editar32X32;
            this.buttonAlterarEstoque.Location = new System.Drawing.Point(111, 8);
            this.buttonAlterarEstoque.Name = "buttonAlterarEstoque";
            this.buttonAlterarEstoque.Size = new System.Drawing.Size(99, 40);
            this.buttonAlterarEstoque.TabIndex = 2;
            this.buttonAlterarEstoque.Text = "Alterar";
            this.buttonAlterarEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAlterarEstoque.UseVisualStyleBackColor = true;
            this.buttonAlterarEstoque.Click += new System.EventHandler(this.buttonAlterarEstoque_Click);
            // 
            // buttonNovoEstoque
            // 
            this.buttonNovoEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNovoEstoque.Image = global::FrontOrdemServico.Properties.Resources.Novo32X32;
            this.buttonNovoEstoque.Location = new System.Drawing.Point(6, 7);
            this.buttonNovoEstoque.Name = "buttonNovoEstoque";
            this.buttonNovoEstoque.Size = new System.Drawing.Size(99, 40);
            this.buttonNovoEstoque.TabIndex = 1;
            this.buttonNovoEstoque.Text = "Novo";
            this.buttonNovoEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNovoEstoque.UseVisualStyleBackColor = true;
            this.buttonNovoEstoque.Click += new System.EventHandler(this.buttonNovoEstoque_Click);
            // 
            // buttonSairEstoque
            // 
            this.buttonSairEstoque.Image = global::FrontOrdemServico.Properties.Resources.Sair32X32;
            this.buttonSairEstoque.Location = new System.Drawing.Point(6, 8);
            this.buttonSairEstoque.Name = "buttonSairEstoque";
            this.buttonSairEstoque.Size = new System.Drawing.Size(84, 40);
            this.buttonSairEstoque.TabIndex = 99;
            this.buttonSairEstoque.Text = "Sair";
            this.buttonSairEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSairEstoque.UseVisualStyleBackColor = true;
            this.buttonSairEstoque.Click += new System.EventHandler(this.buttonSairEstoque_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonSairEstoque);
            this.panel5.Location = new System.Drawing.Point(1094, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 50);
            this.panel5.TabIndex = 99;
            // 
            // buttonPesquisaEstoque
            // 
            this.buttonPesquisaEstoque.Image = global::FrontOrdemServico.Properties.Resources.Lupa32X32;
            this.buttonPesquisaEstoque.Location = new System.Drawing.Point(668, 7);
            this.buttonPesquisaEstoque.Name = "buttonPesquisaEstoque";
            this.buttonPesquisaEstoque.Size = new System.Drawing.Size(99, 40);
            this.buttonPesquisaEstoque.TabIndex = 4;
            this.buttonPesquisaEstoque.Text = "Pesquisar";
            this.buttonPesquisaEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPesquisaEstoque.UseVisualStyleBackColor = true;
            this.buttonPesquisaEstoque.Click += new System.EventHandler(this.buttonPesquisaEstoque_Click);
            // 
            // textBoxPesquisaEstoque
            // 
            this.textBoxPesquisaEstoque.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPesquisaEstoque.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPesquisaEstoque.Location = new System.Drawing.Point(3, 9);
            this.textBoxPesquisaEstoque.Name = "textBoxPesquisaEstoque";
            this.textBoxPesquisaEstoque.Size = new System.Drawing.Size(659, 36);
            this.textBoxPesquisaEstoque.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonPesquisaEstoque);
            this.panel6.Controls.Add(this.textBoxPesquisaEstoque);
            this.panel6.Location = new System.Drawing.Point(321, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(773, 50);
            this.panel6.TabIndex = 2;
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
            this.panel1.TabIndex = 6;
            // 
            // FormPrincipalEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipalEstoque";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipalEstoque_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Código;
        private DataGridView dataGridViewEstoque;
        private Panel panel2;
        private DataGridViewTextBoxColumn codigo;
        private Panel panel4;
        private Button buttonAlterarEstoque;
        private Button buttonNovoEstoque;
        private Button buttonSairEstoque;
        private Panel panel5;
        private Button buttonPesquisaEstoque;
        private TextBox textBoxPesquisaEstoque;
        private Panel panel6;
        private Panel panel1;
        private DataGridViewTextBoxColumn CodigoItem_Estoque;
        private DataGridViewTextBoxColumn nomeItem_Estoque;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button buttonExcluirEstoque;
    }
}