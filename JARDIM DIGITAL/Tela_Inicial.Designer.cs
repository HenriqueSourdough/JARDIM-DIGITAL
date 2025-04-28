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
            this.btnFechar_TelaInicial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnFechar_TelaInicial);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 644);
            this.panel1.TabIndex = 0;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(41, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 32);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar_TelaInicial;
        private System.Windows.Forms.Button button1;
    }
}