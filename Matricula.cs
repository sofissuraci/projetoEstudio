using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Matricula
    {
        public bool cadastrarMatricula(String idTurma, String cpf)
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Matricula(idTurma, cpf) values  ('" + idTurma + "','" + cpf + "')", DAO_Conexao.con);
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

        public int contarAluno(String idTurma)
        {
            MySqlDataReader resultado = null;
            int qntdAlunos = 0;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT COUNT(cpf) FROM Estudio_Matricula WHERE idTurma = '" + idTurma + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                while (resultado.Read())
                {
                    qntdAlunos = int.Parse(resultado["count(cpf)"].ToString());
                }

                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {

            }
            return qntdAlunos;
        }

        public bool excluirMatricula(String cpf)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("DELETE FROM Estudio_Matricula WHERE cpf = '"+ cpf +"'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
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

        public MySqlDataReader consultarAlunos(String idTurma)
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Matricula where idTurma = '" + idTurma + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();

                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {

            }
            return resultado;
        }

        public MySqlDataReader consultarMatricula(String idTurma)
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno INNER JOIN Estudio_Matricula ON Estudio_Aluno.CPFAluno = Estudio_Matricula.cpf WHERE Estudio_Matricula.idTurma= '" + idTurma + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();

                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {

            }
            return resultado;
        }
    }
}
