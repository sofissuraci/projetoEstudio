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
    public partial class ExcluirModalidade : Form
    {
        public ExcluirModalidade()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarTodasModalidade();
            while (r.Read())
            {
                cmbDescricaoMod.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void grpbModalidades_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcluirMod_Click(object sender, EventArgs e)
        {
            try
            {
                Modalidade m = new Modalidade(cmbDescricaoMod.SelectedItem.ToString());
                if (m.excluirModalidade())
                {
                    cmbDescricaoMod.Text = "";
                    MessageBox.Show("Modalidade excluída com sucesso");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cmbDescricaoMod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
