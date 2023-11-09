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
    public partial class CadastrarAluno : Form
    {
        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAtua_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            byte[] foto = ConverterFotoParaByteArray();

            Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEnd.Text, txtNumero.Text, txtBairro.Text,
                txtCompl.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text, foto);

            if (aluno.verificaCPF())
            {
                if (aluno.consultarAluno() == false)
                { 
                    if (aluno.cadastrarAluno())
                MessageBox.Show("Aluno cadastrado com sucesso");
                    else
                MessageBox.Show("Erro no cadastro");

                }
                else
                {
                    MessageBox.Show("Aluno já cadastrado");
                }
            }
            else
            {
                MessageBox.Show("CPF inválido");
            }
        }

        private byte[] ConverterFotoParaByteArray()

        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                //deslocamento de bytes em relação ao parâmetro original
                //redefine a posição do fluxo para a gravação
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                //Lê um bloco de bytes e grava os dados em um buffer (stream)
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);
            if (e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno já cadastrado");

                }
                else
                {
                    txtNome.Focus();
                }
                DAO_Conexao.con.Close();
            }
        }

        private void btnAtua_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEnd.Text, txtNumero.Text, txtBairro.Text,
                txtCompl.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text);
            if (aluno.consultarAluno())
            {
                if (aluno.atualizarAluno())
                {
                    MessageBox.Show("Aluno atualizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro!");
                }

            }
            else
                MessageBox.Show("Aluno não existe");


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }//catch
            }//if
            dialog.Dispose();
        }
    }
}
