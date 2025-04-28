namespace JARDIM_DIGITAL
{
    partial class Tela_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCatalogoPlantas = new System.Windows.Forms.Button();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.btnFechar_TelaInicial = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCatalogoPlantas);
            this.panel1.Controls.Add(this.btnMenuInicial);
            this.panel1.Controls.Add(this.btnFechar_TelaInicial);
            this.panel1.Location = new System.Drawing.Point(-2, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 655);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(860, 505);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 99);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnCatalogoPlantas
            // 
            this.btnCatalogoPlantas.BackColor = System.Drawing.Color.Teal;
            this.btnCatalogoPlantas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCatalogoPlantas.BackgroundImage")));
            this.btnCatalogoPlantas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCatalogoPlantas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCatalogoPlantas.Location = new System.Drawing.Point(365, 472);
            this.btnCatalogoPlantas.Name = "btnCatalogoPlantas";
            this.btnCatalogoPlantas.Size = new System.Drawing.Size(58, 46);
            this.btnCatalogoPlantas.TabIndex = 4;
            this.btnCatalogoPlantas.UseVisualStyleBackColor = false;
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.BackColor = System.Drawing.Color.Teal;
            this.btnMenuInicial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuInicial.BackgroundImage")));
            this.btnMenuInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInicial.Location = new System.Drawing.Point(477, 472);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(58, 46);
            this.btnMenuInicial.TabIndex = 2;
            this.btnMenuInicial.UseVisualStyleBackColor = false;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // btnFechar_TelaInicial
            // 
            this.btnFechar_TelaInicial.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFechar_TelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar_TelaInicial.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar_TelaInicial.Location = new System.Drawing.Point(977, 13);
            this.btnFechar_TelaInicial.Name = "btnFechar_TelaInicial";
            this.btnFechar_TelaInicial.Size = new System.Drawing.Size(20, 23);
            this.btnFechar_TelaInicial.TabIndex = 1;
            this.btnFechar_TelaInicial.Text = "X";
            this.btnFechar_TelaInicial.UseVisualStyleBackColor = false;
            this.btnFechar_TelaInicial.Click += new System.EventHandler(this.btnFechar_TelaInicial_Click);
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 641);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Inicial";
            this.Text = "Tela_Inicial";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar_TelaInicial;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCatalogoPlantas;
    }
}