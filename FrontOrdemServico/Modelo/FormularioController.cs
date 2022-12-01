using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontOrdemServico.Modelo
{
    public partial class FormularioController : Form
    {
        public FormularioController()
        {
            InitializeComponent();
        }

        protected virtual void AtualizarPermissaoBotao(bool prEditando = false)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].Enabled = !prEditando;                   
                }
            }
        }

        protected void AtualizarPermissaoFormulario(bool prEditando)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Enabled = !prEditando;
                    this.Controls[i].BackColor = Color.White;
                }

                if (this.Controls[i] is ComboBox)
                {
                    this.Controls[i].Enabled = !prEditando;
                    this.Controls[i].BackColor = Color.White;
                }               
            }
 
            AtualizarPermissaoBotao(prEditando);
        }

        protected static void LimparFormulario(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox && c.Enabled)
                {
                    ((TextBox)c).Text = "";
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = "";
                }
            }
        }

        protected void FormController_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter || (e.KeyCode == Keys.Return))
            {
                SendKeys.Send("{TAB}");
            }
        }

        protected void FormularioController_KeyPress(object sender, KeyPressEventArgs e)
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

        protected void textBox_Click(object sender, EventArgs e)
        {
            (sender as TextBoxBase).SelectAll();
        }

        protected void textBoxToCurrency(object sender, EventArgs e)
        {
            if (sender != null)
            {
                TextBox textBox = sender as TextBox;

                if (!String.IsNullOrEmpty(textBox.Text))
                {
                    var valor = Convert.ToDecimal(textBox.Text);
                    textBox.Text = String.Format("{0:N2}", valor);
                }
            }
        }

    }
}
