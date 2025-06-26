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
    public partial class frm_Inicio : Form
    {
        public frm_Inicio()
        {
            InitializeComponent();
            
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            frm_Login frm_Login = new frm_Login();
            frm_Login.Show();
            this.Hide();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Sessao.UsuarioId = 0;
            Sessao.NomeUsuario = null;
            Sessao.EmailUsuario = null;

            frm_Login login = new frm_Login();
            login.Show();
            this.Close();
        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            frm_Cadastro_Usuário frm_Cadastro_Usuário = new frm_Cadastro_Usuário();
            frm_Cadastro_Usuário.Show();
            this.Hide();
        }
    }
}
