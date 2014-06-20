using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVR.CadCompra.UI
{
    public class FormFilho : Form
    {
        public FormFilho()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }
        
        public frmPrincipal Principal
        {
            set;
            get;
        }

        protected void MostrarMensagem(string mensagem)
        {
            MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
