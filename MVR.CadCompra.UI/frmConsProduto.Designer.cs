namespace MVR.CadCompra.UI
{
    partial class frmConsProduto
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
            this.gdvProdutos = new System.Windows.Forms.DataGridView();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.txtCodigoSaida = new System.Windows.Forms.TextBox();
            this.lblCodigoSaida = new System.Windows.Forms.Label();
            this.txtCodigoEntrada = new System.Windows.Forms.TextBox();
            this.lblCodigoEntrada = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).BeginInit();
            this.grpFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdvProdutos
            // 
            this.gdvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProdutos.Location = new System.Drawing.Point(14, 176);
            this.gdvProdutos.MultiSelect = false;
            this.gdvProdutos.Name = "gdvProdutos";
            this.gdvProdutos.ReadOnly = true;
            this.gdvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvProdutos.Size = new System.Drawing.Size(733, 315);
            this.gdvProdutos.TabIndex = 1;
            this.gdvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvProdutos_CellDoubleClick);
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.txtCodigoSaida);
            this.grpFiltro.Controls.Add(this.lblCodigoSaida);
            this.grpFiltro.Controls.Add(this.txtCodigoEntrada);
            this.grpFiltro.Controls.Add(this.lblCodigoEntrada);
            this.grpFiltro.Controls.Add(this.btnPesquisar);
            this.grpFiltro.Controls.Add(this.chkAtivo);
            this.grpFiltro.Controls.Add(this.txtCodigo);
            this.grpFiltro.Controls.Add(this.lblCodigo);
            this.grpFiltro.Controls.Add(this.lblDescricao);
            this.grpFiltro.Controls.Add(this.txtDescricao);
            this.grpFiltro.Location = new System.Drawing.Point(14, 12);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(733, 158);
            this.grpFiltro.TabIndex = 0;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtro";
            // 
            // txtCodigoSaida
            // 
            this.txtCodigoSaida.Location = new System.Drawing.Point(122, 117);
            this.txtCodigoSaida.Name = "txtCodigoSaida";
            this.txtCodigoSaida.Size = new System.Drawing.Size(303, 21);
            this.txtCodigoSaida.TabIndex = 8;
            // 
            // lblCodigoSaida
            // 
            this.lblCodigoSaida.AutoSize = true;
            this.lblCodigoSaida.Location = new System.Drawing.Point(21, 120);
            this.lblCodigoSaida.Name = "lblCodigoSaida";
            this.lblCodigoSaida.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoSaida.TabIndex = 7;
            this.lblCodigoSaida.Text = "Código Saída";
            // 
            // txtCodigoEntrada
            // 
            this.txtCodigoEntrada.Location = new System.Drawing.Point(122, 88);
            this.txtCodigoEntrada.Name = "txtCodigoEntrada";
            this.txtCodigoEntrada.Size = new System.Drawing.Size(303, 21);
            this.txtCodigoEntrada.TabIndex = 6;
            // 
            // lblCodigoEntrada
            // 
            this.lblCodigoEntrada.AutoSize = true;
            this.lblCodigoEntrada.Location = new System.Drawing.Point(21, 91);
            this.lblCodigoEntrada.Name = "lblCodigoEntrada";
            this.lblCodigoEntrada.Size = new System.Drawing.Size(95, 13);
            this.lblCodigoEntrada.TabIndex = 5;
            this.lblCodigoEntrada.Text = "Código Entrada";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(632, 115);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkAtivo.Location = new System.Drawing.Point(366, 26);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 2;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.ThreeState = true;
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(121, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(180, 21);
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
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(21, 58);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(63, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(121, 55);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(598, 21);
            this.txtDescricao.TabIndex = 4;
            // 
            // frmConsProduto
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 503);
            this.Controls.Add(this.gdvProdutos);
            this.Controls.Add(this.grpFiltro);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmConsProduto";
            this.Text = "Consulta de Produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsProduto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).EndInit();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView gdvProdutos;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCodigoSaida;
        private System.Windows.Forms.Label lblCodigoSaida;
        private System.Windows.Forms.TextBox txtCodigoEntrada;
        private System.Windows.Forms.Label lblCodigoEntrada;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}