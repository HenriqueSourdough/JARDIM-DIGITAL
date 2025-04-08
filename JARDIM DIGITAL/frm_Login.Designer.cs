namespace JARDIM_DIGITAL
{
    partial class frm_Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnRecuperarSenha = new System.Windows.Forms.Button();
            this.btnEntrarLogin = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.btnCadastreAqui = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFechar_Login = new System.Windows.Forms.Button();
            this.tbxNovaSenha = new System.Windows.Forms.TextBox();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(862, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.DarkCyan;
            this.lblEmail.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(302, 403);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-MAIL";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.DarkCyan;
            this.lblSenha.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(517, 403);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 16);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "SENHA";
            // 
            // btnRecuperarSenha
            // 
            this.btnRecuperarSenha.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRecuperarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecuperarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecuperarSenha.Location = new System.Drawing.Point(508, 448);
            this.btnRecuperarSenha.Name = "btnRecuperarSenha";
            this.btnRecuperarSenha.Size = new System.Drawing.Size(100, 20);
            this.btnRecuperarSenha.TabIndex = 3;
            this.btnRecuperarSenha.Text = "recuperar senha";
            this.btnRecuperarSenha.UseVisualStyleBackColor = false;
            this.btnRecuperarSenha.Click += new System.EventHandler(this.btnRecuperarSenha_Click);
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrarLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarLogin.Location = new System.Drawing.Point(385, 490);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(117, 27);
            this.btnEntrarLogin.TabIndex = 4;
            this.btnEntrarLogin.Text = "ENTRAR";
            this.btnEntrarLogin.UseVisualStyleBackColor = false;
            this.btnEntrarLogin.Click += new System.EventHandler(this.btnEntrarLogin_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(287, 422);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenha.Location = new System.Drawing.Point(508, 422);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(100, 20);
            this.tbxSenha.TabIndex = 6;
            // 
            // btnCadastreAqui
            // 
            this.btnCadastreAqui.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastreAqui.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastreAqui.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastreAqui.Location = new System.Drawing.Point(672, 494);
            this.btnCadastreAqui.Name = "btnCadastreAqui";
            this.btnCadastreAqui.Size = new System.Drawing.Size(143, 23);
            this.btnCadastreAqui.TabIndex = 7;
            this.btnCadastreAqui.Text = "CADASTRE-SE AQUI";
            this.btnCadastreAqui.UseVisualStyleBackColor = false;
            this.btnCadastreAqui.Click += new System.EventHandler(this.btnCadastreAqui_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(466, 413);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(246, 413);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(274, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 261);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // btnFechar_Login
            // 
            this.btnFechar_Login.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFechar_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar_Login.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar_Login.Location = new System.Drawing.Point(826, 7);
            this.btnFechar_Login.Name = "btnFechar_Login";
            this.btnFechar_Login.Size = new System.Drawing.Size(21, 24);
            this.btnFechar_Login.TabIndex = 26;
            this.btnFechar_Login.Text = "X";
            this.btnFechar_Login.UseVisualStyleBackColor = false;
            this.btnFechar_Login.Click += new System.EventHandler(this.btnFechar_Login_Click);
            // 
            // tbxNovaSenha
            // 
            this.tbxNovaSenha.Location = new System.Drawing.Point(654, 422);
            this.tbxNovaSenha.Name = "tbxNovaSenha";
            this.tbxNovaSenha.Size = new System.Drawing.Size(100, 20);
            this.tbxNovaSenha.TabIndex = 27;
            this.tbxNovaSenha.Visible = false;
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.BackColor = System.Drawing.Color.Teal;
            this.lblNovaSenha.Location = new System.Drawing.Point(669, 403);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(67, 13);
            this.lblNovaSenha.TabIndex = 28;
            this.lblNovaSenha.Text = "Nova Senha";
            this.lblNovaSenha.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 558);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNovaSenha);
            this.Controls.Add(this.tbxNovaSenha);
            this.Controls.Add(this.btnFechar_Login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnCadastreAqui);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.btnEntrarLogin);
            this.Controls.Add(this.btnRecuperarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.Text = "frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnRecuperarSenha;
        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Button btnCadastreAqui;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFechar_Login;
        private System.Windows.Forms.TextBox tbxNovaSenha;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.TextBox textBox1;
    }
}