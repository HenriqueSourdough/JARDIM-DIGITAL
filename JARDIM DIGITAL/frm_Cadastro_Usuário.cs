using MySql.Data.MySqlClient;
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

        private void BtnFechar_CadastroUsuario_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFechar_CadastroUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            frm_Login frm_Login = new frm_Login();
            frm_Login.Show();
            this.Hide();
        }

        private void BtnEntrarCadastroUsuario_Click(object sender, EventArgs e)
        {
            if (tbxSenha.Text == tbxConfirmarSenha.Text)
            {


                Usuario novoUsuario = new Usuario
                {
                    Nome = tbxNome.Text,
                    Senha = tbxSenha.Text,
                    Email = tbxEmail.Text
                };

                novoUsuario.RegisterUsuario();
            }
            else
            {
                MessageBox.Show("Senha Incorreta", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeletar_Click_1(object sender, EventArgs e)
        {
            Usuario usuarioDeletado = new Usuario
            {
                Email = tbxEmail.Text,
                Senha = tbxSenha.Text,

            };

            Usuario.DeletarUsuario(usuarioDeletado.Email, usuarioDeletado.Senha);

        }

        private void btnLoginCadastro_Click(object sender, EventArgs e)
        {

            string Email = tbxEmail.Text;
            string Senha = tbxSenha.Text;

            using (var cn = new MySqlConnection(Conn.conn))
            {
                cn.Open();
                string sql = "SELECT * FROM usuarios WHERE Email = @Email AND Senha = @Senha";
                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Senha", Senha);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Salva os dados globais
                            Sesaao.EmailUsuario = Email;
                            Sesaao.SenhaUsuario = Senha;

                            MessageBox.Show("Login realizado com sucesso!");

                            // Aqui você pode abrir o menu principal ou outro form
                            this.Hide();
                            new frm_Login().Show();
                        }
                        else
                        {
                            MessageBox.Show("E-mail ou senha incorretos.");
                        }
                    }
                }
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            Usuario usuarioAtualizado = new Usuario
            {
                ID_Usuario = Convert.ToInt32(tbxID_Usuario.Text),
                Nome = tbxNome.Text,
                Senha = tbxSenha.Text,
            };

            usuarioAtualizado.updateUsuario();
        }
    }
}






