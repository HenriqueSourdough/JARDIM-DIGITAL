namespace JARDIM_DIGITAL
{
    partial class Detalhe_Planta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalhe_Planta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picture_detalhe_planta = new System.Windows.Forms.PictureBox();
            this.lblNomePlanta = new System.Windows.Forms.Label();
            this.lblNomeCientifico = new System.Windows.Forms.Label();
            this.lblDetalhePlanta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_detalhe_planta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblDetalhePlanta);
            this.panel1.Controls.Add(this.lblNomeCientifico);
            this.panel1.Controls.Add(this.lblNomePlanta);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.picture_detalhe_planta);
            this.panel1.Location = new System.Drawing.Point(1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 456);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(332, 326);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 379);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 1;
            // 
            // picture_detalhe_planta
            // 
            this.picture_detalhe_planta.Location = new System.Drawing.Point(313, 55);
            this.picture_detalhe_planta.Name = "picture_detalhe_planta";
            this.picture_detalhe_planta.Size = new System.Drawing.Size(167, 162);
            this.picture_detalhe_planta.TabIndex = 0;
            this.picture_detalhe_planta.TabStop = false;
            // 
            // lblNomePlanta
            // 
            this.lblNomePlanta.AutoSize = true;
            this.lblNomePlanta.Location = new System.Drawing.Point(335, 254);
            this.lblNomePlanta.Name = "lblNomePlanta";
            this.lblNomePlanta.Size = new System.Drawing.Size(35, 13);
            this.lblNomePlanta.TabIndex = 4;
            this.lblNomePlanta.Text = "Nome";
            // 
            // lblNomeCientifico
            // 
            this.lblNomeCientifico.AutoSize = true;
            this.lblNomeCientifico.Location = new System.Drawing.Point(335, 309);
            this.lblNomeCientifico.Name = "lblNomeCientifico";
            this.lblNomeCientifico.Size = new System.Drawing.Size(83, 13);
            this.lblNomeCientifico.TabIndex = 5;
            this.lblNomeCientifico.Text = "Nome Científico";
            // 
            // lblDetalhePlanta
            // 
            this.lblDetalhePlanta.AutoSize = true;
            this.lblDetalhePlanta.Location = new System.Drawing.Point(337, 362);
            this.lblDetalhePlanta.Name = "lblDetalhePlanta";
            this.lblDetalhePlanta.Size = new System.Drawing.Size(44, 13);
            this.lblDetalhePlanta.TabIndex = 6;
            this.lblDetalhePlanta.Text = "Detalhe";
            // 
            // Detalhe_Planta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Detalhe_Planta";
            this.Text = "Detalhe_Planta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_detalhe_planta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picture_detalhe_planta;
        private System.Windows.Forms.Label lblDetalhePlanta;
        private System.Windows.Forms.Label lblNomeCientifico;
        private System.Windows.Forms.Label lblNomePlanta;
    }
}