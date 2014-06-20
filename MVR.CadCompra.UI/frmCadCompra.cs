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
    public partial class frmCadCompra : FormFilho
    {
        public frmCadCompra()
        {
            InitializeComponent();
            LimparCampos(true, true);
        }

        private List<Produto> _produtos;
        private List<ItemCompra> _itens;
        private ItemCompra _itemSelecionado;

        private void frmCadCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Principal.CadCompra = null;
        }

        private void frmCadCompra_Load(object sender, EventArgs e)
        {

        }

        private void LimparCampos(bool limparDadosDaCompra, bool limparItens)
        {
            if (limparDadosDaCompra)
            {
                dtpData.Value = DateTime.Today;
                txtCodigoProcesso.Text = string.Empty;
            }

            _produtos = Produto.Listar(new Produto() { Ativo = true });
            AtualizarComboProduto();
            txtPreco.Text =
                txtQuantidade.Text =
                txtProdutoFiltro.Text =
                string.Empty;
            rdbCodigoEntrada.Checked = true;

            if (limparItens)
            {
                _itens = new List<ItemCompra>();
                AtualizarItens();
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            _produtos = Produto.Listar(new Produto() { Ativo = true });
            if (rdbCodigoEntrada.Checked)
            {
                _produtos = _produtos.Where(p => p.CodigoEntrada == txtProdutoFiltro.Text).ToList();
            }
            else if (rdbCodigoSaida.Checked)
            {
                _produtos = _produtos.Where(p => p.CodigoSaida == txtProdutoFiltro.Text).ToList();
            }
            else
            {
                _produtos = _produtos.Where(p => p.Descricao.Contains(txtProdutoFiltro.Text)).ToList();
            }
            AtualizarComboProduto();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Principal.AbrirCadastroProduto(null, sender);
        }

        public void SelecionarProduto(Produto p)
        {
            _produtos.Clear();
            _produtos.Add(p);
            AtualizarComboProduto();

        }

        private void AtualizarComboProduto()
        {
            cboProduto.DataSource = null;
            cboProduto.ValueMember = "Codigo";
            cboProduto.DisplayMember = "Descricao";
            cboProduto.DataSource = _produtos;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                ItemCompra i = CarregarItem();
                if (_itens.Contains(i, ItemCompra.PesquisaPorCodigoEntrada))
                    throw new ApplicationException("Este produto já foi adicionado");

                _itens.Add(i);
                AtualizarItens();
                LimparCampos(false, false);
            }
            catch (Exception ex)
            {
                MostrarMensagem(ex.Message);
            }
        }

        private void AtualizarItens()
        {
            gdvItensCompra.DataSource = null;

            var itens = from i in _itens select new { CodigoEntrada = i.Produto.CodigoEntrada, Produto = i.Produto.Descricao, Quantidade = i.Quantidade, Preço = i.Preco, ValorTotal = i.Preco * i.Quantidade };
            var total = from i in _itens select new { CodigoEntrada = "", Produto = "Total", Quantidade = _itens.Sum(item => item.Quantidade), Preço = 0m, ValorTotal = _itens.Sum(item => item.Preco * item.Quantidade) };
            gdvItensCompra.DataSource = itens.Union(total).ToList();
            gdvItensCompra.CurrentCell = null;
        }

        private ItemCompra CarregarItem()
        {
            ItemCompra i = new ItemCompra();
            try
            {
                i.Produto = new Produto(Convert.ToInt32(cboProduto.SelectedValue));
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Selecione um produto", ex);
            }

            try
            {
                i.Preco = Convert.ToDecimal(txtPreco.Text);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Digite o preço corretamente", ex);
            }

            try
            {
                i.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Digite a quantidade corretamente", ex);
            }

            return i;

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_itemSelecionado != null)
            {
                _itens.Remove(_itemSelecionado);
                _itemSelecionado = null;
                AtualizarItens();
            }
        }

        private void gdvItensCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < _itens.Count && e.RowIndex > -1)
            {
                _itemSelecionado = _itens[e.RowIndex];
                ExibirItem(_itemSelecionado);
            }
        }

        private void ExibirItem(ItemCompra item)
        {
            txtPreco.Text = item.Preco.ToString();
            txtQuantidade.Text = item.Quantidade.ToString();
            _produtos.Clear();
            _produtos.Add(item.Produto);
            AtualizarComboProduto();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Compra c = new Compra();
                c.AdicionarItens(_itens);
                c.Processo = txtCodigoProcesso.Text;
                c.Data = dtpData.Value;
                c.Salvar();
                LimparCampos(true, true);
            }
            catch (Exception ex)
            {
                MostrarMensagem(ex.Message);
            }
        }
    }
}
