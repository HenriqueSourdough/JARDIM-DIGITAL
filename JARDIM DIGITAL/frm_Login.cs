using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        private void btnEntrarLogin_Click_1(object sender, EventArgs e)
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

                    frm_Tela_Inicial tela_Inicial = new frm_Tela_Inicial();
                    tela_Inicial.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login não encontrado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCadastreAqui_Click_1(object sender, EventArgs e)
        {
            frm_Cadastro_Usuário frm_Cadastro_Usuário = new frm_Cadastro_Usuário();
            frm_Cadastro_Usuário.Show();
            this.Close();
        }

        private void btnRecuperarSenha_Click_1(object sender, EventArgs e)
        {
            lblNovaSenha.Visible = true;
            tbxNovaSenha.Visible = true;
            btnOK.Visible = true;

            Usuario usuarioNovaSenha = new Usuario();

            {

                string email = tbxEmail.Text;
                string novaSenha = tbxNovaSenha.Text;

                // bool sucesso = Usuario.RecuperaSenhaUsuario();


                if (email == "")
                {
                    MessageBox.Show("Preencha, por favor, o campo do Usuário!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tbxNovaSenha.Focus();




                }
            }
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {

            string email = tbxEmail.Text;
            string novaSenha = tbxNovaSenha.Text;
            if (novaSenha != "")
            {


                DataTable usuario = Usuario.RecuperaSenhaUsuario(email, novaSenha);
                // MessageBox.Show(nomeUsuario,"Formuário");
                //MessageBox.Show(senhaUsuario, "Formulário");




                frm_Login frm_Login = new frm_Login();
                frm_Login.Show();
                this.Hide();

                lblNovaSenha.Visible = false;
                tbxNovaSenha.Visible = false;
                btnOK.Visible = false;

            }
        }

        private void btnFechar_Login_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
