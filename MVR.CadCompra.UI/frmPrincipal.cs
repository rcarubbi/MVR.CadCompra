using System;
using System.Windows.Forms;
using MVR.CadCompra.BLL;

namespace MVR.CadCompra.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public FormFilho CadProduto { get; set; }

        public FormFilho CadCompra { get; set; }

        public FormFilho ConsProduto { get; set; }

        public FormFilho ConsCompra { get; set; }

        public void AbrirCadastroProduto(Produto produto, object sender)
        {
            if (CadProduto == null)
            {
                CadProduto = new frmCadProduto(produto, sender);
                CadProduto.MdiParent = this;
                CadProduto.Principal = this;
                CadProduto.Show();
            }
            else
            {
                if (produto != null)
                {
                    ((frmCadProduto) CadProduto).ExibirProduto(produto);
                    CadProduto.Focus();
                }
            }
        }

        private void mnuCadastroProduto_Click(object sender, EventArgs e)
        {
            AbrirCadastroProduto(null, null);
        }

        private void mnuCadastroCompra_Click(object sender, EventArgs e)
        {
            if (CadCompra == null)
            {
                CadCompra = new frmCadCompra();
                CadCompra.MdiParent = this;
                CadCompra.Principal = this;
                CadCompra.Show();
            }
        }

        private void mnuConsultaProduto_Click(object sender, EventArgs e)
        {
            if (ConsProduto == null)
            {
                ConsProduto = new frmConsProduto();
                ConsProduto.MdiParent = this;
                ConsProduto.Principal = this;
                ConsProduto.Show();
            }
        }

        private void mnuConsultaCompra_Click(object sender, EventArgs e)
        {
            if (ConsCompra == null)
            {
                ConsCompra = new frmConsCompra();
                ConsCompra.MdiParent = this;
                ConsCompra.Principal = this;
                ConsCompra.Show();
            }
        }

        private void frmPrincipal_ResizeEnd(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }
    }
}