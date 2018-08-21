using System.Windows.Forms;

namespace MVR.CadCompra.UI
{
    public class FormFilho : Form
    {
        public FormFilho()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public frmPrincipal Principal { set; get; }

        protected void MostrarMensagem(string mensagem)
        {
            MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}