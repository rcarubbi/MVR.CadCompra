using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVR.CadCompra.BLL;
using System.IO;

namespace MVR.CadCompra.UI
{
    public partial class frmCadProduto : FormFilho
    {
        public frmCadProduto()
        {
            InitializeComponent();
            LimparCampos();
        }
        private object _sender;
        private string _caminhoImagemArquivo;
        public frmCadProduto(Produto produto, object sender)
            : this()
        {
            _sender = sender;
            if (produto != null)
                ExibirProduto(produto);
        }
       

        private void frmCadProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Principal.CadProduto = null;
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
            int idProduto = String.IsNullOrEmpty(txtCodigo.Text)? 0 : Convert.ToInt32(txtCodigo.Text);
            Produto produto = new Produto(idProduto);
            produto.Descricao = txtDescricao.Text;
            produto.Ativo =  chkAtivo.Checked;
            produto.CodigoEntrada = txtCodigoEntrada.Text;
            produto.CodigoSaida = txtCodigoSaida.Text;
            produto.CaminhoArquivoImagem = _caminhoImagemArquivo;
            return produto;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = CarregarProduto();
                p.Salvar();
                LimparCampos();

                if (_sender is Button && ((Button)_sender).Name == "btnNovo")
                {
                    ((frmCadCompra)this.Principal.CadCompra).SelecionarProduto(p);
                    this.Close();
                }

                if (Principal.ConsProduto != null)
                {
                    ((frmConsProduto)Principal.ConsProduto).AtualizarPesquisa();
                
                }
               
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
            DialogResult result = openFileDialog1.ShowDialog();
           
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                _caminhoImagemArquivo = openFileDialog1.FileName;
                CopiarImagem(openFileDialog1.OpenFile(), openFileDialog1.FileName);
                CarregarImagem();
            }
        }

        private void CopiarImagem(System.IO.Stream stream, string sourceFilePath)
        {
            string targetPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Path.GetFileName(sourceFilePath));
            if (!File.Exists(targetPath))
                CopyStream(stream, new FileStream(targetPath, FileMode.CreateNew));
            _caminhoImagemArquivo = targetPath;
        }

        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[32768];
            while (true)
            {
                int read = input.Read(buffer, 0, buffer.Length);
                if (read <= 0)
                    break;
                output.Write(buffer, 0, read);
            }
            input.Close();
            output.Close();
            input.Dispose();
            output.Dispose();
            input = null;
            output = null;
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
