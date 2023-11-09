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
    public partial class ExcluirAluno : Form
    {
        public ExcluirAluno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {

        }

        private void mskCpfAluno_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void mskCpfAluno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCpf.Text);

            if (e.KeyChar == 13) ;
            {
                if (aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno encontrado");
                    if (aluno.excluirAluno())
                    {
                        MessageBox.Show("Aluno excluído com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro!");
                    }
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
