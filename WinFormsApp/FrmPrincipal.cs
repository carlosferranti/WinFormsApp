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
            //
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre  = new FrmSobre();
            frmSobre.ShowDialog();
            if (frmSobre.IsDisposed)
                Close();
        }
    }
}