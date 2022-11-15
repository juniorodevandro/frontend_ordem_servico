using FrontOrdemServico.View;

namespace FrontOrdemServico
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPessoa form = new FormPessoa();
            form.ShowDialog();
        }

        private void itemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormItem form = new FormItem();
            form.ShowDialog();
        }
    }
}