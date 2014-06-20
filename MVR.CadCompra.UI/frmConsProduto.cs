using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVR.CadCompra.BLL;

namespace MVR.CadCompra.UI
{
    public partial class frmConsProduto : FormFilho
    {
        public frmConsProduto()
        {
            InitializeComponent();
        }

        private List<Produto> UltimaPesquisa;

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                UltimaPesquisa = Produto.Listar(CarregarFiltro());
                gdvProdutos.DataSource = UltimaPesquisa;
                gdvProdutos.CurrentCell = null;
            }
            catch (NotFoundException ex)
            {
                MostrarMensagem(ex.Message);
            }
        }

        private Produto CarregarFiltro()
        {
            Produto produto = new Produto();

            produto.Codigo = string.IsNullOrEmpty(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text);
            produto.Descricao = txtDescricao.Text;
            produto.Ativo = (chkAtivo.CheckState == CheckState.Indeterminate) ?  (bool?)null : chkAtivo.Checked;
            produto.CodigoEntrada = txtCodigoEntrada.Text;
            produto.CodigoSaida = txtCodigoSaida.Text; 
            return produto;
        }

        private void frmConsProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Principal.ConsProduto = null;
        }

         

        internal void AtualizarPesquisa()
        {
            btnPesquisar_Click(null, EventArgs.Empty);
        }

        private void gdvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < UltimaPesquisa.Count && e.RowIndex > -1)
                this.Principal.AbrirCadastroProduto(UltimaPesquisa[e.RowIndex], sender);
        }
    }
}
