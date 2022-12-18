namespace WinFormsApp
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnCadClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(1019, 20);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(107, 38);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 15);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 25);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(1019, 83);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(107, 38);
            this.btnSobre.TabIndex = 2;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnCadClientes
            // 
            this.btnCadClientes.Location = new System.Drawing.Point(1019, 275);
            this.btnCadClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadClientes.Name = "btnCadClientes";
            this.btnCadClientes.Size = new System.Drawing.Size(107, 38);
            this.btnCadClientes.TabIndex = 3;
            this.btnCadClientes.Text = "Clientes";
            this.btnCadClientes.UseVisualStyleBackColor = true;
            this.btnCadClientes.Click += new System.EventHandler(this.btnCadClientes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 784);
            this.Controls.Add(this.btnCadClientes);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnFinalizar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFinalizar;
        private Label lblID;
        private Button btnSobre;
        private Button btnCadClientes;
    }
}