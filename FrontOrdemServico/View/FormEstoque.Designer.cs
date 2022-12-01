namespace FrontOrdemServico.View
{
    partial class FormEstoque
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
            System.Windows.Forms.Button buttonSalvarEstoque;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            System.Windows.Forms.Button buttonCancelarEstoque;
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            buttonSalvarEstoque = new System.Windows.Forms.Button();
            buttonCancelarEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSalvarEstoque
            // 
            buttonSalvarEstoque.BackColor = System.Drawing.SystemColors.ControlLightLight;
            buttonSalvarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvarEstoque.Image")));
            buttonSalvarEstoque.Location = new System.Drawing.Point(471, 49);
            buttonSalvarEstoque.Name = "buttonSalvarEstoque";
            buttonSalvarEstoque.Size = new System.Drawing.Size(61, 36);
            buttonSalvarEstoque.TabIndex = 22;
            buttonSalvarEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSalvarEstoque.UseVisualStyleBackColor = false;
            buttonSalvarEstoque.Click += new System.EventHandler(this.buttonSalvarEstoque_Click);
            // 
            // buttonCancelarEstoque
            // 
            buttonCancelarEstoque.BackColor = System.Drawing.SystemColors.ControlLightLight;
            buttonCancelarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelarEstoque.Image")));
            buttonCancelarEstoque.Location = new System.Drawing.Point(538, 49);
            buttonCancelarEstoque.Name = "buttonCancelarEstoque";
            buttonCancelarEstoque.Size = new System.Drawing.Size(61, 36);
            buttonCancelarEstoque.TabIndex = 23;
            buttonCancelarEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCancelarEstoque.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxQuantidade.Location = new System.Drawing.Point(498, 20);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.ReadOnly = true;
            this.textBoxQuantidade.Size = new System.Drawing.Size(101, 23);
            this.textBoxQuantidade.TabIndex = 17;
            this.textBoxQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(10, 20);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(480, 23);
            this.comboBoxEstado.TabIndex = 24;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 87);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(buttonSalvarEstoque);
            this.Controls.Add(buttonCancelarEstoque);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label1;
        private TextBox textBoxQuantidade;
        private ComboBox comboBoxEstado;
    }
}