namespace MVR.CadCompra.UI
{
    partial class frmConsCompra
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
            this.gdvCompras = new System.Windows.Forms.DataGridView();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.chkPeriodo = new System.Windows.Forms.CheckBox();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.txtCodigoSaida = new System.Windows.Forms.TextBox();
            this.lblCodigoSaida = new System.Windows.Forms.Label();
            this.txtCodigoEntrada = new System.Windows.Forms.TextBox();
            this.lblCodigoEntrada = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCompras)).BeginInit();
            this.grpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvCompras
            // 
            this.gdvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCompras.Location = new System.Drawing.Point(14, 180);
            this.gdvCompras.MultiSelect = false;
            this.gdvCompras.Name = "gdvCompras";
            this.gdvCompras.ReadOnly = true;
            this.gdvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvCompras.Size = new System.Drawing.Size(887, 346);
            this.gdvCompras.TabIndex = 0;
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.picProduto);
            this.grpFiltro.Controls.Add(this.chkPeriodo);
            this.grpFiltro.Controls.Add(this.lblDataFim);
            this.grpFiltro.Controls.Add(this.dtpDataFim);
            this.grpFiltro.Controls.Add(this.dtpDataInicio);
            this.grpFiltro.Controls.Add(this.lblDataInicio);
            this.grpFiltro.Controls.Add(this.txtCodigoSaida);
            this.grpFiltro.Controls.Add(this.lblCodigoSaida);
            this.grpFiltro.Controls.Add(this.txtCodigoEntrada);
            this.grpFiltro.Controls.Add(this.lblCodigoEntrada);
            this.grpFiltro.Controls.Add(this.btnPesquisar);
            this.grpFiltro.Location = new System.Drawing.Point(14, 12);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(887, 162);
            this.grpFiltro.TabIndex = 1;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtro";
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(749, 15);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(131, 112);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduto.TabIndex = 23;
            this.picProduto.TabStop = false;
            // 
            // chkPeriodo
            // 
            this.chkPeriodo.AutoSize = true;
            this.chkPeriodo.Location = new System.Drawing.Point(514, 133);
            this.chkPeriodo.Name = "chkPeriodo";
            this.chkPeriodo.Size = new System.Drawing.Size(105, 17);
            this.chkPeriodo.TabIndex = 8;
            this.chkPeriodo.Text = "Habilitar Período";
            this.chkPeriodo.UseVisualStyleBackColor = true;
            this.chkPeriodo.CheckedChanged += new System.EventHandler(this.chkPeriodo_CheckedChanged);
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(311, 133);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(14, 13);
            this.lblDataFim.TabIndex = 6;
            this.lblDataFim.Text = "a";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(334, 128);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(160, 21);
            this.dtpDataFim.TabIndex = 7;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(141, 128);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(160, 21);
            this.dtpDataInicio.TabIndex = 5;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(23, 134);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(73, 13);
            this.lblDataInicio.TabIndex = 4;
            this.lblDataInicio.Text = "Período de:";
            // 
            // txtCodigoSaida
            // 
            this.txtCodigoSaida.Location = new System.Drawing.Point(141, 100);
            this.txtCodigoSaida.Name = "txtCodigoSaida";
            this.txtCodigoSaida.Size = new System.Drawing.Size(353, 21);
            this.txtCodigoSaida.TabIndex = 3;
            // 
            // lblCodigoSaida
            // 
            this.lblCodigoSaida.AutoSize = true;
            this.lblCodigoSaida.Location = new System.Drawing.Point(23, 103);
            this.lblCodigoSaida.Name = "lblCodigoSaida";
            this.lblCodigoSaida.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoSaida.TabIndex = 2;
            this.lblCodigoSaida.Text = "Código Saída";
            // 
            // txtCodigoEntrada
            // 
            this.txtCodigoEntrada.Location = new System.Drawing.Point(141, 71);
            this.txtCodigoEntrada.Name = "txtCodigoEntrada";
            this.txtCodigoEntrada.Size = new System.Drawing.Size(353, 21);
            this.txtCodigoEntrada.TabIndex = 1;
            // 
            // lblCodigoEntrada
            // 
            this.lblCodigoEntrada.AutoSize = true;
            this.lblCodigoEntrada.Location = new System.Drawing.Point(23, 74);
            this.lblCodigoEntrada.Name = "lblCodigoEntrada";
            this.lblCodigoEntrada.Size = new System.Drawing.Size(95, 13);
            this.lblCodigoEntrada.TabIndex = 0;
            this.lblCodigoEntrada.Text = "Código Entrada";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(749, 133);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(131, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmConsCompra
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 538);
            this.Controls.Add(this.gdvCompras);
            this.Controls.Add(this.grpFiltro);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmConsCompra";
            this.Text = "Consulta de Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsCompra_FormClosing);
            this.Load += new System.EventHandler(this.frmConsCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvCompras)).EndInit();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.TextBox txtCodigoSaida;
        private System.Windows.Forms.Label lblCodigoSaida;
        private System.Windows.Forms.TextBox txtCodigoEntrada;
        private System.Windows.Forms.Label lblCodigoEntrada;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView gdvCompras;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.CheckBox chkPeriodo;
        private System.Windows.Forms.PictureBox picProduto;
    }
}