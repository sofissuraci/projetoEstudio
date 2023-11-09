using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Estudio
{
    class Turma
    {
        private String professor;
        private String dia_semana;
        private String hora;
        private int modalidade;

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }

        public Turma(int modalidade, String professor, String dia_semana, String hora)
        {
            Professor = professor;
            Dia_semana = dia_semana;
            Hora = hora;
            Modalidade = modalidade;

        }

        public Turma(int modalidade)
        {
            this.Modalidade = modalidade;

        }

        public Turma(int modalidade, String dia_semana)
        {
            Modalidade = modalidade;
            Dia_semana = dia_semana;
        }



        public Turma()
        {

        }

        public bool cadastrarTurma()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Turma(idModalidade, professorTurma, diasemanaTurma, horaTurma) values  (" + Modalidade + ",'" + Professor + "','" + dia_semana + "','" + hora + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public bool excluirTurma()
        {
            bool exc = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand excluir = new MySqlCommand("UPDATE Estudio_Turma SET ativo = 1 where idModalidade = '" + Modalidade + "'", DAO_Conexao.con);
                excluir.ExecuteNonQuery();
                exc = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        public MySqlDataReader consultarTurma()
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idModalidade = " + Modalidade + "", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    Console.WriteLine("Achou");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public MySqlDataReader consultarTodasTurmas()
        {
            bool existe = false;
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public bool atualizarTurma()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("UPDATE Estudio_Turma SET professorTurma = '" + Professor + "', diasemanaTurma = '" + Dia_semana + "', horaTurma = '" + Hora + "' WHERE idModalidade = " + Modalidade + "", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }
    }
}
