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
            string nomeUsuario = tbxEmail.Text;
            string senhaUsuario = tbxSenha.Text;

            if (nomeUsuario == "" || senhaUsuario == "")
            {
                MessageBox.Show("Preencha, por favor, o campo do Usuário ou Senha!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable usuario = Usuario.GetUsuario(nomeUsuario, senhaUsuario);
                // MessageBox.Show(nomeUsuario,"Formuário");
                //MessageBox.Show(senhaUsuario, "Formulário");


                if (usuario.Rows.Count > 0)
                {
                    //saber se o Banco de Dados foi Acessado

                    Tela_Inicial tela_Inicial = new Tela_Inicial();
                    tela_Inicial.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login não encontrado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
