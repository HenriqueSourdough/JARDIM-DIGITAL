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
    public partial class frm_Cadastro_Usuário : Form
    {
        public frm_Cadastro_Usuário()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFechar_CadastroUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frm_Login frm_Login = new frm_Login();
            frm_Login.Show();
            this.Hide();
        }

        private void btnEntrarCadastroUsuario_Click(object sender, EventArgs e)
        {
            if (tbxSenha.Text == tbxConfirmarSenha.Text)
            {


                Usuario novoUsuario = new Usuario
                {
                    Nome = tbxNome.Text,
                    Senha = tbxSenha.Text,
                    Email = tbxEmail.Text
                };

                novoUsuario.registerUsuario();
            }
            else
            {
                MessageBox.Show("Senha Incorreta", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            Usuario usuarioAtualizado = new Usuario
            {
                id_usuario = Convert.ToInt32(tbxidusuario.Text),
                Nome = tbxidusuario.Text,
                Senha = tbxSenha.Text,
            };
            usuarioAtualizado.AtualizarUsuario();

        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            Usuario usuarioDeletado = new Usuario
            {
                Email = tbxEmail.Text,
                Senha = tbxSenha.Text,

            };

            Usuario.DeletarUsuario(usuarioDeletado.Email, usuarioDeletado.Senha);

        }

        
    }
    }


        
   
    

