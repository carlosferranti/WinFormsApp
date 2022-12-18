using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmPadrao : Form
    {
        public FrmPadrao()
        {
            InitializeComponent();
        }

        private void FrmPadrao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //

        }

        private void FrmPadrao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        //private void HabilitaDesabilitaControles(bool Value)
        //{
        //    foreach (Control ctl in this.Controls)
        //    {
        //        if (ctl is Panel)
        //            continue;
        //        ctl.Enabled = Value;
        //    }
        //}

        private void LimpaControles()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                    (ctl as TextBox).Text = "";
                if (ctl is ComboBox)
                    (ctl as ComboBox).SelectedIndex = -1;
                if (ctl is ListBox)
                    (ctl as ListBox).SelectedIndex = -1;
            }
        }

        private void FrmPadrao_Load(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(TipoOperacao.scBrowser);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(TipoOperacao.scEdit);
        }

        public void HabilitaDesabilitaControles(int operacao)
        {
            // funções de cada operação
            // ------------------------
            // 0 - Default
            // 1 - novo
            // 2 - salvar
            // 3 - excluir ou alterar
            // 4 - cancelar                      

            if (operacao == 0) // Default
            {
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
                btnPesquisar.Enabled = true;
                btnSair.Enabled = true;
            }

            if (operacao == 1) // novo
            {
                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = true;
                btnPesquisar.Enabled = false;
                btnSair.Enabled = false;
            }

            if (operacao == 2) // salvar
            {
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
                btnPesquisar.Enabled = true;
                btnSair.Enabled = true;
            }

            if (operacao == 3) // excluir ou alterar
            {
                //
            }

            if (operacao == 4) // cancelar
            {
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnPesquisar.Enabled = true;
                btnSair.Enabled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(TipoOperacao.scInsert);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(TipoOperacao.scEdit);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(TipoOperacao.scBrowser);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(TipoOperacao.scCancel);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(TipoOperacao.scBrowser);
        }
    }

    //public enum TipoOperacao
    //{
    //    scBrowser = 0,
    //    scInsert = 1,
    //    scSave = 2,
    //    scEdit = 3,
    //    scCancel = 4
    //}

    public class TipoOperacao
    {
        public static int scBrowser = 0;
        public static int scInsert = 1;
        public static int scSave = 2;
        public static int scEdit = 3;
        public static int scCancel = 4;
    }
}