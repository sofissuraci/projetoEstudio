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

namespace Estudio
{
    public partial class ExcluirTurma : Form
    {
        public ExcluirTurma()
        {
            InitializeComponent();

            Turma turma = new Turma();

            MySqlDataReader resultado = turma.consultarTodasTurmas();

            while (resultado.Read())
                cbmIdMod.Items.Add(resultado["idModalidade"].ToString());

            DAO_Conexao.con.Close();


        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void btnExcuir_Click(object sender, EventArgs e)
        {
            try
            {
                Turma t = new Turma(int.Parse(cbmIdMod.SelectedItem.ToString()));

                if (t.excluirTurma())
                {
                    MessageBox.Show("Turma excluída com sucesso");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cbmIdTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turma turma = new Turma(int.Parse(cbmIdMod.SelectedItem.ToString()));

            MySqlDataReader show = turma.consultarTurma();

            {
                txtDiaSemana.Text = show["diasemanaTurma"].ToString();
                txtHora.Text = show["horaTurma"].ToString();
            }

            DAO_Conexao.con.Close();
        }

        private void lblTurma_Click(object sender, EventArgs e)
        {

        }

        private void cbmIdMod_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
