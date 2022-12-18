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
    public partial class FrmPadrao : Form
    {
        //public enum StatusOperacao
        //{
        //    scInsert, scBrowser, scEdit, scCancel
        //}

        public string StatusOperacao;


        public enum sStatus
        {

        }
        public sStatus status;

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

        private void HabilitaDesabilitaControles(bool Value)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is Panel)
                    continue;
                ctl.Enabled = Value;
            }
        }

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
            //sStatus = StatusCadastro.scBrowser;
            //LimpaControles();
            //HabilitaDesabilitaControles(false);
        }

        //public virtual bool Salvar()
        //{

        //}

        //public virtual bool Excluir()
        //{

        //}

        //public virtual bool Localizar()
        //{

        //}

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //if (Salvar())
            //{
            //    sStatus = StatusCadastro.scBrowser;
            //    HabilitaDesabilitaControles(false);
            //    MessageBox.Show("Registro salvo com sucesso!",
            //    "Salvar", MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
            //}
        }

        public void AlterarBotoes(int operacao)
        {
            // funções de cada botão
            // 1 - inserir e localizar
            // 2 - inserir/alterar
            // 3 - preparar para excluir ou alterar

            panel.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnPesquisar.Enabled = false;
            btnExcluir.Enabled = false;
            //btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            if (operacao == 1)
            {
                btnSalvar.Enabled = true;
                btnPesquisar.Enabled = true;
            }

            if (operacao == 2)
            {
                panel.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (operacao == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace WinFormsApp
//{
//    public partial class FrmPadrao : Form
//    {
//        public enum StatusCadastro
//        {
//            scInsert, scBrowser, scEdit, scCancel
//        }

//        public enum sStatus
//        {

//        }
//        public sStatus status;  

//        public FrmPadrao()
//        {
//            InitializeComponent();
//        }

//        private void FrmPadrao_KeyPress(object sender, KeyPressEventArgs e)
//        {

//        }

//        private void FrmPadrao_KeyDown(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Escape)
//                this.Close();
//        }

//        private void HabilitaDesabilitaControles(bool Value)
//        {
//            foreach (Control ctl in this.Controls)
//            {
//                if (ctl is Panel)
//                    continue;
//                ctl.Enabled = Value;
//            }
//        }

//        private void LimpaControles()
//        {
//            foreach (Control ctl in this.Controls)
//            {
//                if (ctl is TextBox)
//                    (ctl as TextBox).Text = "";
//                if (ctl is ComboBox)
//                    (ctl as ComboBox).SelectedIndex = -1;
//                if (ctl is ListBox)
//                    (ctl as ListBox).SelectedIndex = -1;
//            }
//        }

//        private void FrmPadrao_Load(object sender, EventArgs e)
//        {
//            sStatus = StatusCadastro.scBrowser;
//            LimpaControles();
//            HabilitaDesabilitaControles(false);
//        }

//        public virtual bool Salvar()
//        { 

//        }

//        public virtual bool Excluir()
//        { 

//        }

//        public virtual bool Localizar()
//        { 

//        }

//        private void btnSalvar_Click(object sender, EventArgs e)
//        {
//            if (Salvar())
//            {
//                sStatus = StatusCadastro.scBrowser;
//                HabilitaDesabilitaControles(false);
//                MessageBox.Show("Registro salvo com sucesso!",
//                "Salvar", MessageBoxButtons.OK,
//                MessageBoxIcon.Information);
//            }
//        }
//    }
//}
