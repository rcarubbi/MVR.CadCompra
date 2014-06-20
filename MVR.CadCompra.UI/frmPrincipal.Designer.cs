namespace MVR.CadCompra.UI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastro,
            this.mnuConsulta,
            this.mnuSobre});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuPrincipal.Size = new System.Drawing.Size(706, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroProduto,
            this.mnuCadastroCompra});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(77, 20);
            this.mnuCadastro.Text = "Cadastro";
            // 
            // mnuCadastroProduto
            // 
            this.mnuCadastroProduto.Name = "mnuCadastroProduto";
            this.mnuCadastroProduto.Size = new System.Drawing.Size(124, 22);
            this.mnuCadastroProduto.Text = "Produto";
            this.mnuCadastroProduto.Click += new System.EventHandler(this.mnuCadastroProduto_Click);
            // 
            // mnuCadastroCompra
            // 
            this.mnuCadastroCompra.Name = "mnuCadastroCompra";
            this.mnuCadastroCompra.Size = new System.Drawing.Size(124, 22);
            this.mnuCadastroCompra.Text = "Compra";
            this.mnuCadastroCompra.Click += new System.EventHandler(this.mnuCadastroCompra_Click);
            // 
            // mnuConsulta
            // 
            this.mnuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConsultaProduto,
            this.mnuConsultaCompra});
            this.mnuConsulta.Name = "mnuConsulta";
            this.mnuConsulta.Size = new System.Drawing.Size(75, 20);
            this.mnuConsulta.Text = "Consulta";
            // 
            // mnuConsultaProduto
            // 
            this.mnuConsultaProduto.Name = "mnuConsultaProduto";
            this.mnuConsultaProduto.Size = new System.Drawing.Size(124, 22);
            this.mnuConsultaProduto.Text = "Produto";
            this.mnuConsultaProduto.Click += new System.EventHandler(this.mnuConsultaProduto_Click);
            // 
            // mnuConsultaCompra
            // 
            this.mnuConsultaCompra.Name = "mnuConsultaCompra";
            this.mnuConsultaCompra.Size = new System.Drawing.Size(124, 22);
            this.mnuConsultaCompra.Text = "Compra";
            this.mnuConsultaCompra.Click += new System.EventHandler(this.mnuConsultaCompra_Click);
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(56, 20);
            this.mnuSobre.Text = "Sobre";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MVR.CadCompra.UI.Properties.Resources.purchasing;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 508);
            this.Controls.Add(this.mnuPrincipal);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Purchasing Manager - Preço FOB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResizeEnd += new System.EventHandler(this.frmPrincipal_ResizeEnd);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuConsulta;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaProduto;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
    }
}

