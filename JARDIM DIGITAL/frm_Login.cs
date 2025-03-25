using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JARDIM_DIGITAL
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            frm_Inicio frm_Inicio = new frm_Inicio();
            frm_Inicio.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
           Tela_Inicial tela_Inicial = new Tela_Inicial();
            tela_Inicial.Show();
            this.Hide();
        }

        private void btnCadastreAqui_Click(object sender, EventArgs e)
        {
            frm_Cadastro_Usuário frm_Cadastro_Usuário = new frm_Cadastro_Usuário();
            frm_Cadastro_Usuário.Show();
            this.Close();
        }

        private void btnFechar_Login_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
