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
        }

        private void FrmSobre_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void FrmSobre_Load(object sender, EventArgs e)
        {         
            Version appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            lblApp.Text = string.Format("Versão do aplicativo: {0}.{1}.{2} ", appVersion.Major, appVersion.Minor, appVersion.Build);
        }    
    }
}
