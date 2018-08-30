using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Carubbi.Extensions;
using MVR.CadCompra.BLL;

namespace MVR.CadCompra.UI
{
    public partial class frmCadProduto : FormFilho
    {
        private string _caminhoImagemArquivo;
        private readonly object _sender;

        public frmCadProduto()
        {
            InitializeComponent();
            LimparCampos();
        }

        public frmCadProduto(Produto produto, object sender)
            : this()
        {
            _sender = sender;
            if (produto != null)
                ExibirProduto(produto);
        }


        private void frmCadProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal.CadProduto = null;
        }

        public void ExibirProduto(Produto produto)
        {
            txtCodigo.Text = produto.Codigo.ToString();
            txtDescricao.Text = produto.Descricao;
            txtCodigoEntrada.Text = produto.CodigoEntrada;
            txtCodigoSaida.Text = produto.CodigoSaida;
            _caminhoImagemArquivo = produto.CaminhoArquivoImagem;
            chkAtivo.Checked = produto.Ativo.HasValue ? produto.Ativo.Value : false;
            CarregarImagem();
        }


        public Produto CarregarProduto()
        {
            var idProduto = string.IsNullOrEmpty(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text);
            var produto = new Produto(idProduto);
            produto.Descricao = txtDescricao.Text;
            produto.Ativo = chkAtivo.Checked;
            produto.CodigoEntrada = txtCodigoEntrada.Text;
            produto.CodigoSaida = txtCodigoSaida.Text;
            produto.CaminhoArquivoImagem = _caminhoImagemArquivo;
            return produto;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var p = CarregarProduto();
                p.Salvar();
                LimparCampos();

                if (_sender is Button && ((Button) _sender).Name == "btnNovo")
                {
                    ((frmCadCompra) Principal.CadCompra).SelecionarProduto(p);
                    Close();
                }

                if (Principal.ConsProduto != null) ((frmConsProduto) Principal.ConsProduto).AtualizarPesquisa();
            }
            catch (Exception ex)
            {
                MostrarMensagem(ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Text =
                txtCodigoEntrada.Text =
                    txtCodigoSaida.Text =
                        txtDescricao.Text = string.Empty;
            chkAtivo.Checked = true;
            picProduto.Image = null;
            picProduto.Refresh();
            txtDescricao.Focus();
        }

        private void frmCadProduto_Shown(object sender, EventArgs e)
        {
            txtDescricao.Focus();
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result != DialogResult.OK) return;
            _caminhoImagemArquivo = openFileDialog1.FileName;
            CopiarImagem(openFileDialog1.OpenFile(), openFileDialog1.FileName);
            CarregarImagem();
        }

        private void CopiarImagem(Stream stream, string sourceFilePath)
        {
            var targetPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                Path.GetFileName(sourceFilePath));
            if (!File.Exists(targetPath))
                stream.CopyTo(new FileStream(targetPath, FileMode.CreateNew));
            _caminhoImagemArquivo = targetPath;
        }

         
        private void CarregarImagem()
        {
            Image imagem = null;
            if (!string.IsNullOrEmpty(_caminhoImagemArquivo))
                imagem = Image.FromFile(_caminhoImagemArquivo);

            picProduto.Image = imagem;
            picProduto.Refresh();
        }

        private void btnLimparImagem_Click(object sender, EventArgs e)
        {
            _caminhoImagemArquivo = string.Empty;
            CarregarImagem();
        }
    }
}