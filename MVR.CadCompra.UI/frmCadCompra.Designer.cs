namespace MVR.CadCompra.UI
{
    partial class frmCadCompra
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
            this.components = new System.ComponentModel.Container();
            this.grpCompra = new System.Windows.Forms.GroupBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.txtCodigoProcesso = new System.Windows.Forms.TextBox();
            this.lblCodigoProcesso = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpAdicionarProduto = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbDescricao = new System.Windows.Forms.RadioButton();
            this.rdbCodigoEntrada = new System.Windows.Forms.RadioButton();
            this.rdbCodigoSaida = new System.Windows.Forms.RadioButton();
            this.lblTipoFiltro = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtProdutoFiltro = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.grpItensCompra = new System.Windows.Forms.GroupBox();
            this.gdvItensCompra = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpCompra.SuspendLayout();
            this.grpAdicionarProduto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpItensCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvItensCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCompra
            // 
            this.grpCompra.Controls.Add(this.dtpData);
            this.grpCompra.Controls.Add(this.lblData);
            this.grpCompra.Controls.Add(this.txtCodigoProcesso);
            this.grpCompra.Controls.Add(this.lblCodigoProcesso);
            this.grpCompra.Location = new System.Drawing.Point(0, 12);
            this.grpCompra.Name = "grpCompra";
            this.grpCompra.Size = new System.Drawing.Size(799, 54);
            this.grpCompra.TabIndex = 0;
            this.grpCompra.TabStop = false;
            this.grpCompra.Text = "Dados da Compra";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(357, 20);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(145, 21);
            this.dtpData.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(317, 26);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data";
            // 
            // txtCodigoProcesso
            // 
            this.txtCodigoProcesso.BackColor = System.Drawing.Color.White;
            this.txtCodigoProcesso.Location = new System.Drawing.Point(147, 23);
            this.txtCodigoProcesso.Name = "txtCodigoProcesso";
            this.txtCodigoProcesso.Size = new System.Drawing.Size(145, 21);
            this.txtCodigoProcesso.TabIndex = 1;
            // 
            // lblCodigoProcesso
            // 
            this.lblCodigoProcesso.AutoSize = true;
            this.lblCodigoProcesso.Location = new System.Drawing.Point(47, 26);
            this.lblCodigoProcesso.Name = "lblCodigoProcesso";
            this.lblCodigoProcesso.Size = new System.Drawing.Size(58, 13);
            this.lblCodigoProcesso.TabIndex = 0;
            this.lblCodigoProcesso.Text = "Processo";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(699, 501);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grpAdicionarProduto
            // 
            this.grpAdicionarProduto.Controls.Add(this.btnRemover);
            this.grpAdicionarProduto.Controls.Add(this.panel1);
            this.grpAdicionarProduto.Controls.Add(this.lblTipoFiltro);
            this.grpAdicionarProduto.Controls.Add(this.btnNovo);
            this.grpAdicionarProduto.Controls.Add(this.btnFiltrar);
            this.grpAdicionarProduto.Controls.Add(this.txtProdutoFiltro);
            this.grpAdicionarProduto.Controls.Add(this.lblProduto);
            this.grpAdicionarProduto.Controls.Add(this.btnAdicionar);
            this.grpAdicionarProduto.Controls.Add(this.cboProduto);
            this.grpAdicionarProduto.Controls.Add(this.txtPreco);
            this.grpAdicionarProduto.Controls.Add(this.lblPreco);
            this.grpAdicionarProduto.Controls.Add(this.txtQuantidade);
            this.grpAdicionarProduto.Controls.Add(this.lblQuantidade);
            this.grpAdicionarProduto.Location = new System.Drawing.Point(0, 72);
            this.grpAdicionarProduto.Name = "grpAdicionarProduto";
            this.grpAdicionarProduto.Size = new System.Drawing.Size(799, 158);
            this.grpAdicionarProduto.TabIndex = 1;
            this.grpAdicionarProduto.TabStop = false;
            this.grpAdicionarProduto.Text = "Adicionar Produto";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(606, 129);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(87, 23);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "-";
            this.toolTip1.SetToolTip(this.btnRemover, "Remover Item da Compra");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbDescricao);
            this.panel1.Controls.Add(this.rdbCodigoEntrada);
            this.panel1.Controls.Add(this.rdbCodigoSaida);
            this.panel1.Location = new System.Drawing.Point(147, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 24);
            this.panel1.TabIndex = 1;
            // 
            // rdbDescricao
            // 
            this.rdbDescricao.AutoSize = true;
            this.rdbDescricao.Location = new System.Drawing.Point(232, 4);
            this.rdbDescricao.Name = "rdbDescricao";
            this.rdbDescricao.Size = new System.Drawing.Size(81, 17);
            this.rdbDescricao.TabIndex = 2;
            this.rdbDescricao.Text = "Descrição";
            this.rdbDescricao.UseVisualStyleBackColor = true;
            // 
            // rdbCodigoEntrada
            // 
            this.rdbCodigoEntrada.AutoSize = true;
            this.rdbCodigoEntrada.Checked = true;
            this.rdbCodigoEntrada.Location = new System.Drawing.Point(6, 4);
            this.rdbCodigoEntrada.Name = "rdbCodigoEntrada";
            this.rdbCodigoEntrada.Size = new System.Drawing.Size(113, 17);
            this.rdbCodigoEntrada.TabIndex = 1;
            this.rdbCodigoEntrada.TabStop = true;
            this.rdbCodigoEntrada.Text = "Código Entrada";
            this.rdbCodigoEntrada.UseVisualStyleBackColor = true;
            // 
            // rdbCodigoSaida
            // 
            this.rdbCodigoSaida.AutoSize = true;
            this.rdbCodigoSaida.Location = new System.Drawing.Point(125, 4);
            this.rdbCodigoSaida.Name = "rdbCodigoSaida";
            this.rdbCodigoSaida.Size = new System.Drawing.Size(101, 17);
            this.rdbCodigoSaida.TabIndex = 0;
            this.rdbCodigoSaida.Text = "Código Saída";
            this.rdbCodigoSaida.UseVisualStyleBackColor = true;
            // 
            // lblTipoFiltro
            // 
            this.lblTipoFiltro.AutoSize = true;
            this.lblTipoFiltro.Location = new System.Drawing.Point(38, 26);
            this.lblTipoFiltro.Name = "lblTipoFiltro";
            this.lblTipoFiltro.Size = new System.Drawing.Size(103, 13);
            this.lblTipoFiltro.TabIndex = 0;
            this.lblTipoFiltro.Text = "Tipo de Pesquisa";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(706, 50);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(80, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(621, 49);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(78, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtProdutoFiltro
            // 
            this.txtProdutoFiltro.Location = new System.Drawing.Point(147, 52);
            this.txtProdutoFiltro.Name = "txtProdutoFiltro";
            this.txtProdutoFiltro.Size = new System.Drawing.Size(466, 21);
            this.txtProdutoFiltro.TabIndex = 3;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(38, 54);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(51, 13);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "Produto";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(699, 129);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(87, 23);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "+";
            this.toolTip1.SetToolTip(this.btnAdicionar, "Adicionar Item da Compra");
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cboProduto
            // 
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(147, 78);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(639, 21);
            this.cboProduto.TabIndex = 6;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(147, 131);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(119, 21);
            this.txtPreco.TabIndex = 10;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(38, 134);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(39, 13);
            this.lblPreco.TabIndex = 9;
            this.lblPreco.Text = "Preço";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(147, 105);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(119, 21);
            this.txtQuantidade.TabIndex = 8;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(38, 108);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(72, 13);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // grpItensCompra
            // 
            this.grpItensCompra.Controls.Add(this.gdvItensCompra);
            this.grpItensCompra.Location = new System.Drawing.Point(0, 236);
            this.grpItensCompra.Name = "grpItensCompra";
            this.grpItensCompra.Size = new System.Drawing.Size(799, 259);
            this.grpItensCompra.TabIndex = 2;
            this.grpItensCompra.TabStop = false;
            this.grpItensCompra.Text = "Itens da Compra";
            // 
            // gdvItensCompra
            // 
            this.gdvItensCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvItensCompra.Location = new System.Drawing.Point(7, 16);
            this.gdvItensCompra.MultiSelect = false;
            this.gdvItensCompra.Name = "gdvItensCompra";
            this.gdvItensCompra.ReadOnly = true;
            this.gdvItensCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvItensCompra.Size = new System.Drawing.Size(785, 237);
            this.gdvItensCompra.TabIndex = 0;
            this.gdvItensCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvItensCompra_CellClick);
            // 
            // frmCadCompra
            // 
            this.AcceptButton = this.btnAdicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.grpItensCompra);
            this.Controls.Add(this.grpAdicionarProduto);
            this.Controls.Add(this.grpCompra);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCadCompra";
            this.Text = "Cadastro de Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadCompra_FormClosing);
            this.Load += new System.EventHandler(this.frmCadCompra_Load);
            this.grpCompra.ResumeLayout(false);
            this.grpCompra.PerformLayout();
            this.grpAdicionarProduto.ResumeLayout(false);
            this.grpAdicionarProduto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpItensCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvItensCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCompra;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodigoProcesso;
        private System.Windows.Forms.Label lblCodigoProcesso;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.GroupBox grpAdicionarProduto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtProdutoFiltro;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.GroupBox grpItensCompra;
        private System.Windows.Forms.DataGridView gdvItensCompra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbDescricao;
        private System.Windows.Forms.RadioButton rdbCodigoEntrada;
        private System.Windows.Forms.RadioButton rdbCodigoSaida;
        private System.Windows.Forms.Label lblTipoFiltro;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}