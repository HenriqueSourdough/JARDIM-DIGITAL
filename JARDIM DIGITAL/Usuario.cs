using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JARDIM_DIGITAL
{
    internal class Usuario
    {

        public int id_suario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string NovaSenha {  get; set; }

        public static DataTable GetUsuario(string Email, string senha)
        {
            var dt = new DataTable();
            var sql = "SELECT id_usuario, Nome, Senha, Email,CEP FROM usuarios WHERE Email = @Email AND Senha = @Senha ";
           


            try// Tentar
            {
                using (var cn = new MySqlConnection(Conn.conn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Senha", senha);
                        //MessageBox.Show(nome,"Banco de Dados");
                        //MessageBox.Show(senha,"Banco de Dados");

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }


                }

            }
            catch (MySqlException erro) //Pegar ou capturar erro
            {
                MessageBox.Show(erro.Message);
            }
            return dt;
        }

        public bool registerUsuario()
        {
            var sql = "INSERT INTO usuarios(Nome,Senha,Email,Cep) VALUES (@Nome, @Senha,@Email,@Cep)";


            try// Tentar
            {
                using (var cn = new MySqlConnection(Conn.conn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", this.Nome);
                        cmd.Parameters.AddWithValue("@Senha", this.Senha);
                        cmd.Parameters.AddWithValue("@Email", this.Email);
                        cmd.Parameters.AddWithValue("@Cep", this.CEP);

                        //ENQ Retorno de quantidade de linhas Afetadas 
                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Usuário Cadastrado com Sucesso", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }


                }

            }
            catch (MySqlException erro) //Pegar ou capturar erro
            {
                MessageBox.Show(erro.Message);
            }
            return false;
        }

        public static DataTable RecuperaSenhaUsuario(string email, string novaSenha)
        {
            var dt = new DataTable();
            var sql = "UPDATE usuarios SET Senha =  @NovaSenha WHERE Email = @Email";

            try
            {
                using (var cn = new MySqlConnection(Conn.conn))
                {
                    cn.Open();

                    using(var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@NovaSenha", novaSenha);

                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Senha redefinida com sucesso!","Recuperação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("E-mail não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            return dt;
        }
            
    }
}

