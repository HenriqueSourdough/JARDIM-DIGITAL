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
    public partial class frm_Cadastro_Plantas : Form
    {
        public frm_Cadastro_Plantas()
        {
            InitializeComponent();
        }

    


        private void btnCadastrarPlantas_Click(object sender, EventArgs e)
        {
            Plantas novosPlantas = new Plantas
            {

                NOME_PLANTA = tbxNomePlanta.Text,
                NOME_CIENTIFICO = tbxNomeCientifico.Text,
                DESC_PLANTA = tbxDescricaoPlanta.Text,
                CUIDADO = tbxCuidadosPlanta.Text,
                CATEGORIA = tbxCategoriaPlanta.Text,

            };

            novosPlantas.registerPlanta();

        }

        private void btnAtualizarCadastroPlantas_Click(object sender, EventArgs e)
        {
            Plantas plantaAtualizada = new Plantas
            {

                NOME_PLANTA = tbxNomePlanta.Text,
                NOME_CIENTIFICO = tbxNomeCientifico.Text,
                DESC_PLANTA = tbxDescricaoPlanta.Text,
                CUIDADO = tbxCuidadosPlanta.Text,
                CATEGORIA = tbxCategoriaPlanta.Text,

            };
            plantaAtualizada.updatePlanta();
        }
    }
}
