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
    public class Plantas
    {
        public int ID_PLANTA { get; set; }
        public string NOME_PLANTA { get; set; }
        public string NOME_CIENTIFICO { get; set; }
        public string DESC_PLANTA { get; set; }
        public string CUIDADO { get; set; }
        public string CATEGORIA { get; set; }
        public string IMAGEMPLANTA { get; set; }


        public static DataTable GetPlanta(string Nome_Planta, string Nome_Cientifico, string Descricao_, string Cuidados_, string Categoria_, string ImagemPlanta)
        {
            var dt = new DataTable();
            var sql = "SELECT NOME_PLANTA, NOME_CIENTIFICO, DESC_PLANTA, CUIDADO, CATEGORIA, IMAGEMPLANTA FROM plantas WHERE NOME_PLANTA =@NomePlanta AND NOME_CIENTIFICO =@NomeCientifico AND DESC_PLANTA =@Descricao AND CUIDADO =@Cuidado AND CATEGORIA =@Categoria AND IMAGEMPLANTA =@LinkImagem ";
            try
            {
                using (var cn = new MySqlConnection(Conn.conn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))

                    {
                        cmd.Parameters.AddWithValue("@NomePlanta", Nome_Planta);
                        cmd.Parameters.AddWithValue("@NomeCientifico", Nome_Cientifico);
                        cmd.Parameters.AddWithValue("@Descricao", Descricao_);
                        cmd.Parameters.AddWithValue("@Cuidado", Cuidados_);
                        cmd.Parameters.AddWithValue("@Categoria", Categoria_);
                        cmd.Parameters.AddWithValue("@LinkImagem", ImagemPlanta);

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
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

        public bool registerPlanta()
        {
            var sql = "INSERT INTO plantas(NOME_PLANTA, NOME_CIENTIFICO, DESC_PLANTA, CUIDADO, CATEGORIA, IMAGEMPLANTA) VALUES (@NomePlanta, @NomeCientifico, @Descricao, @Cuidado, @Categoria,@LinkImagem)";

            try
            {
                using (var cn = new MySqlConnection(Conn.conn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@NomePlanta", this.NOME_PLANTA);
                        cmd.Parameters.AddWithValue("@NomeCientifico", this.NOME_CIENTIFICO);
                        cmd.Parameters.AddWithValue("@Descricao", this.DESC_PLANTA);
                        cmd.Parameters.AddWithValue("@Cuidado", this.CUIDADO);
                        cmd.Parameters.AddWithValue("@Categoria", CATEGORIA);
                        cmd.Parameters.AddWithValue("@LinkImagem", IMAGEMPLANTA);

                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Planta Cadastrada com Sucesso", "Cadastro de Plantas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }


            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);
            }

            return false;
        }

        public bool deletePlanta()
        {
            if (this.ID_PLANTA == 0)
            {
                MessageBox.Show("Comando Inválido", "DELETE PLANTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string sql = "DELETE from plantas WHERE ID_PLANTA = @ID_PLANTA";

            try
            {
                using (var cn = new MySqlConnection(Conn.conn))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@ID_PLANTA", this.ID_PLANTA);
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Planta deletada com sucesso", "DELETE PLANT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }


            }

            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);
            }

            return false;
                        
        }
        public bool updatePlanta()
        {
            if (this.ID_PLANTA == 0)
            {
                MessageBox.Show("id inválido", "updatePlanta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string sql = "UPDATE plantas SET NOME_PLANTA = @NomePlanta , NOME_CIENTIFICO = @Senha WHERE USU_IDUsuario = @IDUsuario";

            try
            {

                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", this.Nome);
                        cmd.Parameters.AddWithValue("@Senha", this.Senha);
                        cmd.Parameters.AddWithValue("@IDUsuario", this.IDUsuario);

                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        //ExecuteNonQuery -> quantidade de linhas afetadas

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Usuário atualizado com sucesso", "Atualização de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }

                }
            }

            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            return false;

        }
    }
 }



