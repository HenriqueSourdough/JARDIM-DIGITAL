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

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            frm_Login frm_Login = new frm_Login();
            frm_Login.Show();
            this.Hide();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            frm_Cadastro_Usuário frm_Cadastro_Usuário = new frm_Cadastro_Usuário();
            frm_Cadastro_Usuário.Show();
            this.Hide();
        }
    }
}
