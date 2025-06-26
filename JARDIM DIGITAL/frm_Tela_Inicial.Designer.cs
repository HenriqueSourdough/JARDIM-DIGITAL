using System.Windows.Forms;
using System;

namespace JARDIM_DIGITAL
{
    partial class frm_Tela_Inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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


        private void frm_Tela_Inicial_Load(object sender, EventArgs e)
        {
            if (Sessao.UsuarioId == 0)
            {
                MessageBox.Show("Você precisa estar logado para acessar essa tela.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                frm_Tela_Inicial login = new frm_Tela_Inicial();
                login.Show();
            }
            else
            {
                lblBoasVindas.Text = "Olá, " + Sessao.NomeUsuario;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Tela_Inicial));
            this.LogoTelaInicial = new System.Windows.Forms.PictureBox();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            this.btnHomeCatalogoPlantas = new System.Windows.Forms.Button();
            this.btnHomeMenu = new System.Windows.Forms.Button();
            this.tbxPesquisarTelaInicial = new System.Windows.Forms.TextBox();
            this.imgLupa = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTelaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoTelaInicial
            // 
            this.LogoTelaInicial.BackColor = System.Drawing.Color.Transparent;
            this.LogoTelaInicial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoTelaInicial.BackgroundImage")));
            this.LogoTelaInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoTelaInicial.Location = new System.Drawing.Point(443, 204);
            this.LogoTelaInicial.Name = "LogoTelaInicial";
            this.LogoTelaInicial.Size = new System.Drawing.Size(196, 154);
            this.LogoTelaInicial.TabIndex = 0;
            this.LogoTelaInicial.TabStop = false;
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.BackColor = System.Drawing.Color.Transparent;
            this.btnTelaInicial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelaInicial.BackgroundImage")));
            this.btnTelaInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaInicial.Location = new System.Drawing.Point(417, 500);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(79, 68);
            this.btnTelaInicial.TabIndex = 1;
            this.btnTelaInicial.UseVisualStyleBackColor = false;
            // 
            // btnHomeCatalogoPlantas
            // 
            this.btnHomeCatalogoPlantas.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeCatalogoPlantas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHomeCatalogoPlantas.BackgroundImage")));
            this.btnHomeCatalogoPlantas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHomeCatalogoPlantas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeCatalogoPlantas.Location = new System.Drawing.Point(565, 500);
            this.btnHomeCatalogoPlantas.Name = "btnHomeCatalogoPlantas";
            this.btnHomeCatalogoPlantas.Size = new System.Drawing.Size(74, 68);
            this.btnHomeCatalogoPlantas.TabIndex = 2;
            this.btnHomeCatalogoPlantas.UseVisualStyleBackColor = false;
            // 
            // btnHomeMenu
            // 
            this.btnHomeMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHomeMenu.BackgroundImage")));
            this.btnHomeMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHomeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeMenu.Location = new System.Drawing.Point(48, 52);
            this.btnHomeMenu.Name = "btnHomeMenu";
            this.btnHomeMenu.Size = new System.Drawing.Size(46, 43);
            this.btnHomeMenu.TabIndex = 3;
            this.btnHomeMenu.UseVisualStyleBackColor = false;
            // 
            // tbxPesquisarTelaInicial
            // 
            this.tbxPesquisarTelaInicial.BackColor = System.Drawing.Color.Teal;
            this.tbxPesquisarTelaInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPesquisarTelaInicial.Location = new System.Drawing.Point(361, 72);
            this.tbxPesquisarTelaInicial.Name = "tbxPesquisarTelaInicial";
            this.tbxPesquisarTelaInicial.Size = new System.Drawing.Size(329, 13);
            this.tbxPesquisarTelaInicial.TabIndex = 5;
            // 
            // imgLupa
            // 
            this.imgLupa.BackColor = System.Drawing.Color.Transparent;
            this.imgLupa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLupa.BackgroundImage")));
            this.imgLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLupa.Location = new System.Drawing.Point(707, 56);
            this.imgLupa.Name = "imgLupa";
            this.imgLupa.Size = new System.Drawing.Size(27, 29);
            this.imgLupa.TabIndex = 6;
            this.imgLupa.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1013, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 43);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Location = new System.Drawing.Point(487, 131);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(58, 13);
            this.lblBoasVindas.TabIndex = 8;
            this.lblBoasVindas.Text = "Bem-Vindo";
          
            // 
            // frm_Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1114, 626);
            this.Controls.Add(this.lblBoasVindas);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.imgLupa);
            this.Controls.Add(this.tbxPesquisarTelaInicial);
            this.Controls.Add(this.btnHomeMenu);
            this.Controls.Add(this.btnHomeCatalogoPlantas);
            this.Controls.Add(this.btnTelaInicial);
            this.Controls.Add(this.LogoTelaInicial);
            this.DoubleBuffered = true;
            this.Name = "frm_Tela_Inicial";
            this.Text = "Tela_Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.LogoTelaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoTelaInicial;
        private System.Windows.Forms.Button btnTelaInicial;
        private System.Windows.Forms.Button btnHomeCatalogoPlantas;
        private System.Windows.Forms.Button btnHomeMenu;
        private System.Windows.Forms.TextBox tbxPesquisarTelaInicial;
        private System.Windows.Forms.PictureBox imgLupa;
        private System.Windows.Forms.Button button4;
        private Label lblBoasVindas;
    }
}