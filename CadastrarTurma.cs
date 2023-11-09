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
    public partial class CadastrarTurma : Form
    {
        public CadastrarTurma()
        {
            InitializeComponent();
            
            Modalidade modalidade = new Modalidade();
            MySqlDataReader resultado = modalidade.consultarTodasModalidade();

            while (resultado.Read())
                cmbModalidade.Items.Add(resultado["descricaoModalidade"].ToString());

            DAO_Conexao.con.Close();

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma(int.Parse(txtModalidade.Text), txtProfessor.Text, txtDiaSemana.Text, txtHora.Text );

            if (turma.cadastrarTurma())
            {
                MessageBox.Show("Turma cadastrada com sucesso");
            }
            else
            {
                MessageBox.Show("Erro");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
