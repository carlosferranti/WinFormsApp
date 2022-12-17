using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp
{
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            //FrmPrincipal frmPrincipal = new FrmPrincipal();
            //frmPrincipal.ShowDialog();
            //frmPrincipal.Show();

            //Form1 _f1;
            //_f1 = new Form1();
            //_f1.Show();
        }

        private void FrmSobre_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void FrmSobre_Load(object sender, EventArgs e)
        {
            //Version appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            //lblApp.Text = string.Format("Versão do aplicativo: {0}.{1}.{2} ", appVersion.Major, appVersion.Minor, appVersion.Build);

            lblApp.Text = GetVersionApp();
        }

        private string GetVersionApp()
        {
            Version appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            return string.Format("Versão do aplicativo: {0}.{1}.{2} ", appVersion.Major, appVersion.Minor, appVersion.Build);

        }
    }
}
