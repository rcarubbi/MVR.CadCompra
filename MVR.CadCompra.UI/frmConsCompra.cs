﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MVR.CadCompra.BLL;

namespace MVR.CadCompra.UI
{
    public partial class frmConsCompra : FormFilho
    {
        private List<Compra> _compras;

        public frmConsCompra()
        {
            InitializeComponent();
        }

        private void frmConsCompra_Load(object sender, EventArgs e)
        {
            VerificarFiltroPeriodo();
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var cInicio = new Compra();
                var cFim = new Compra();
                var produtoFiltro = new Produto();


                if (chkPeriodo.Checked)
                {
                    cInicio.Data = dtpDataInicio.Value;
                    cFim.Data = dtpDataFim.Value;
                }

                produtoFiltro.CodigoEntrada = txtCodigoEntrada.Text;
                produtoFiltro.CodigoSaida = txtCodigoSaida.Text;


                _compras = Compra.Listar(cInicio, cFim, produtoFiltro);
                AtualizarCompras();

                var produto = Produto.Listar(produtoFiltro).FirstOrDefault();
                CarregarImagem(produto);
            }
            catch (Exception ex)
            {
                MostrarMensagem(ex.Message);
            }
        }

        private void CarregarImagem(Produto produto)
        {
            if (produto != null && !string.IsNullOrEmpty(produto.CaminhoArquivoImagem))
            {
                picProduto.Image = Image.FromFile(produto.CaminhoArquivoImagem);
                picProduto.Refresh();
            }
        }

        private void AtualizarCompras()
        {
            gdvCompras.DataSource = null;

            if (_compras.Count > 0)
            {
                var comprasPrimeiraLinha = from cur in _compras.Take(1)
                    select new
                    {
                        cur.Processo,
                        cur.Data,
                        cur.Itens.Where(i => i.Produto.CodigoEntrada == txtCodigoEntrada.Text).FirstOrDefault()
                            .Quantidade,
                        Preço = string.Format("{0:00.00}",
                            cur.Itens.Where(i => i.Produto.CodigoEntrada == txtCodigoEntrada.Text).FirstOrDefault()
                                .Preco),
                        Percentual = "0 %"
                    };


                var compras = _compras.SelectWithPrevious((prev, cur) => new
                {
                    cur.Processo,
                    cur.Data,
                    cur.Itens.Where(i => i.Produto.CodigoEntrada == txtCodigoEntrada.Text).FirstOrDefault().Quantidade,
                    Preço = string.Format("{0:00.00}",
                        cur.Itens.Where(i => i.Produto.CodigoEntrada == txtCodigoEntrada.Text).FirstOrDefault().Preco),
                    Percentual = string.Format("{0:00.00} %",
                        (cur.Itens.Where(i => i.Produto.CodigoEntrada == txtCodigoEntrada.Text).FirstOrDefault().Preco -
                         prev.Itens.Where(i => i.Produto.CodigoEntrada == txtCodigoEntrada.Text).FirstOrDefault().Preco)
                        / prev.Itens.Where(i => i.Produto.CodigoEntrada == txtCodigoEntrada.Text).FirstOrDefault()
                            .Preco * 100)
                });
                gdvCompras.DataSource = comprasPrimeiraLinha.Union(compras).ToList();
            }
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            VerificarFiltroPeriodo();
        }

        private void VerificarFiltroPeriodo()
        {
            dtpDataFim.Enabled =
                dtpDataInicio.Enabled = chkPeriodo.Checked;
        }

        private void frmConsCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal.ConsCompra = null;
        }
    }
}