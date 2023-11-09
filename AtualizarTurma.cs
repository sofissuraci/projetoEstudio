using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Estudio
{
    public partial class atualizaTurma : Form
    {
        public atualizaTurma()
        {
            InitializeComponent();

            Turma turma = new Turma();

            MySqlDataReader resultado = turma.consultarTodasTurmas();

            while (resultado.Read())
                cmbModalidade.Items.Add(resultado["idModalidade"].ToString());

            DAO_Conexao.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Turma turma = new Turma(int.Parse(cmbModalidade.SelectedItem.ToString()));

            MySqlDataReader show = turma.consultarTurma();

            {
                txtProfessor.Text = show["professorTurma"].ToString();
                txtDiaSemana.Text = show["diasemanaTurma"].ToString();
                txtHora.Text = show["horaTurma"].ToString();
            }

            DAO_Conexao.con.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma(int.Parse(cmbModalidade.Text), txtProfessor.Text, txtDiaSemana.Text, txtHora.Text);

            if (turma.atualizarTurma())
                MessageBox.Show("Modalidade atualizada com sucesso");
            else
                MessageBox.Show("Erro!");
        }

        private void grbAtualizar_Enter(object sender, EventArgs e)
        {

        }
    }
}
