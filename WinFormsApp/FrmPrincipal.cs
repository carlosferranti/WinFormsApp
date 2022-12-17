using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //


        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //if (e.CloseReason != CloseReason.UserClosing)
            //    return;

            if (MessageBox.Show("Deseja realmente sair?", "Aviso", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Warning) == DialogResult.OK)
                Application.Exit();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
            //if (frmSobre.IsDisposed)
            //    Hide();

            //FrmSobre frmSobre  = new FrmSobre();
            //frmSobre.ShowDialog();
            //if (frmSobre.IsDisposed)
            //    Hide();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;
            
            e.Cancel = true;

        }
    }
}