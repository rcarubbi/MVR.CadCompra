namespace MVR.CadCompra.UI
{
    partial class frmCadProduto
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.btnLimparImagem = new System.Windows.Forms.Button();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.txtCodigoSaida = new System.Windows.Forms.TextBox();
            this.lblCodigoSaida = new System.Windows.Forms.Label();
            this.txtCodigoEntrada = new System.Windows.Forms.TextBox();
            this.lblCodigoEntrada = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images files|*.jpg;*.gif;";
            // 
            // grpProduto
            // 
            this.grpProduto.Controls.Add(this.btnLimparImagem);
            this.grpProduto.Controls.Add(this.btnCarregarImagem);
            this.grpProduto.Controls.Add(this.picProduto);
            this.grpProduto.Controls.Add(this.txtCodigoSaida);
            this.grpProduto.Controls.Add(this.lblCodigoSaida);
            this.grpProduto.Controls.Add(this.txtCodigoEntrada);
            this.grpProduto.Controls.Add(this.lblCodigoEntrada);
            this.grpProduto.Controls.Add(this.chkAtivo);
            this.grpProduto.Controls.Add(this.txtDescricao);
            this.grpProduto.Controls.Add(this.lblDescricao);
            this.grpProduto.Controls.Add(this.txtCodigo);
            this.grpProduto.Controls.Add(this.lblCodigo);
            this.grpProduto.Location = new System.Drawing.Point(14, 12);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(727, 439);
            this.grpProduto.TabIndex = 1;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "Produto";
            // 
            // btnLimparImagem
            // 
            this.btnLimparImagem.Location = new System.Drawing.Point(482, 164);
            this.btnLimparImagem.Name = "btnLimparImagem";
            this.btnLimparImagem.Size = new System.Drawing.Size(129, 23);
            this.btnLimparImagem.TabIndex = 10;
            this.btnLimparImagem.Text = "Limpar Imagem";
            this.btnLimparImagem.UseVisualStyleBackColor = true;
            this.btnLimparImagem.Click += new System.EventHandler(this.btnLimparImagem_Click);
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(482, 135);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(129, 23);
            this.btnCarregarImagem.TabIndex = 9;
            this.btnCarregarImagem.Text = "Carregar Imagem";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // picProduto
            // 
            this.picProduto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduto.Location = new System.Drawing.Point(121, 135);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(353, 303);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduto.TabIndex = 24;
            this.picProduto.TabStop = false;
            // 
            // txtCodigoSaida
            // 
            this.txtCodigoSaida.Location = new System.Drawing.Point(121, 109);
            this.txtCodigoSaida.Name = "txtCodigoSaida";
            this.txtCodigoSaida.Size = new System.Drawing.Size(353, 21);
            this.txtCodigoSaida.TabIndex = 8;
            // 
            // lblCodigoSaida
            // 
            this.lblCodigoSaida.AutoSize = true;
            this.lblCodigoSaida.Location = new System.Drawing.Point(21, 112);
            this.lblCodigoSaida.Name = "lblCodigoSaida";
            this.lblCodigoSaida.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoSaida.TabIndex = 7;
            this.lblCodigoSaida.Text = "Código Saída";
            // 
            // txtCodigoEntrada
            // 
            this.txtCodigoEntrada.Location = new System.Drawing.Point(121, 83);
            this.txtCodigoEntrada.Name = "txtCodigoEntrada";
            this.txtCodigoEntrada.Size = new System.Drawing.Size(353, 21);
            this.txtCodigoEntrada.TabIndex = 6;
            // 
            // lblCodigoEntrada
            // 
            this.lblCodigoEntrada.AutoSize = true;
            this.lblCodigoEntrada.Location = new System.Drawing.Point(20, 86);
            this.lblCodigoEntrada.Name = "lblCodigoEntrada";
            this.lblCodigoEntrada.Size = new System.Drawing.Size(95, 13);
            this.lblCodigoEntrada.TabIndex = 5;
            this.lblCodigoEntrada.Text = "Código Entrada";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(267, 25);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(55, 17);
            this.chkAtivo.TabIndex = 2;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(121, 54);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(598, 21);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(21, 57);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(63, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(121, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(138, 21);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(47, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(646, 457);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadProduto
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 489);
            this.Controls.Add(this.grpProduto);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCadProduto";
            this.Text = "Cadastro de Produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadProduto_FormClosing);
            this.Shown += new System.EventHandler(this.frmCadProduto_Shown);
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoSaida;
        private System.Windows.Forms.Label lblCodigoSaida;
        private System.Windows.Forms.TextBox txtCodigoEntrada;
        private System.Windows.Forms.Label lblCodigoEntrada;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLimparImagem;
    }
}