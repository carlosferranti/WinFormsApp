using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public class StatusOperacao
    {
        public static int scDefault = 1;
        public static int scBrowser = 2;
        public static int scEdit = 3;
        public static int scCancel = 4;
    }
    public partial class FrmPadrao : Form
    {
        public FrmPadrao()
        {
            InitializeComponent();
        }

        private void FrmPadrao_KeyPress(object sender, KeyPressEventArgs e)
        {

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

            HabilitaDesabilitaControles(StatusOperacao.scBrowser);
        }
               

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(2);          
        }

        public void HabilitaDesabilitaControles(int operacao)
        {
            // funções de cada operação
            // 1 - inserir e localizar
            // 2 - inserir/alterar
            // 3 - preparar para excluir ou alterar
            // 4 - padrão                      

            if (operacao == 1) // inserir
            {
                btnSalvar.Enabled = true;
                btnPesquisar.Enabled = true;
                btnCancelar.Enabled = true;
                btnPesquisar.Enabled = false;
                btnSair.Enabled = false;
            }

            if (operacao == 2) //  inserir/alterar
            {
                panel.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (operacao == 3) // excluir ou alterar
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (operacao == 4) // padrão
            {
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnPesquisar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }              

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(StatusOperacao.scEdit);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(StatusOperacao.scEdit);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(StatusOperacao.scDefault);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(StatusOperacao.scCancel);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(StatusOperacao.scDefault);
        }
    }
}