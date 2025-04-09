using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_ToDoList.DAL
{
    internal class tarefaDAL
    {
        public static List<tarefaDTO> listaDeTarefas = new List<tarefaDTO>();

        public static List<tarefaDTO> ListarTarefas()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = "SELECT * FROM Tarefas";

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a instância de uma classe)
                DataTable minhaTabela = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(minhaTabela);
                // Retornar o objeto dataTable preenchido

                listaDeTarefas.Clear();

                for (int i = 0; i < minhaTabela.Rows.Count; i++)
                {
                    listaDeTarefas.Add(
                        new tarefaDTO(
                            (int)minhaTabela.Rows[i][0],
                           (string)minhaTabela.Rows[i][1],
                           (string)minhaTabela.Rows[i][2],
                           (int)minhaTabela.Rows[i][3]


                        )
                    );

                }

                return listaDeTarefas;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }

        public static void AdicionarTarefa(string nome, string descricao, int importancia)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"INSERT INTO Tarefas(nomeTarefa, descricaoTarefa, importanciaTarefa)" +
                $"VALUES(\"{nome} \", \"{descricao}\", {importancia})";

            MySqlCommand mySqlCommand = new MySqlCommand(query, minhaConexao.Start());

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                minhaConexao.Close();
            }
        }

        public static void ExcluirTarefa(int ID)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"DELETE FROM tarefas WHERE idTarefa = {ID};";

            MySqlCommand mySqlCommand = new MySqlCommand(query, minhaConexao.Start());

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                minhaConexao.Close();
            }
        }


        public static void EditarTarefa(tarefaDTO minhaTarefa)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"UPDATE Tarefas SET " +
                 $"nomeTarefa = \"{minhaTarefa.Nome}\", " +
                 $"descricaoTarefa = \"{minhaTarefa.Descricao}\", " +
                 $"importanciaTarefa= {minhaTarefa.Importancia} " +
                 $" WHERE idTarefa = {minhaTarefa.ID}";



            MySqlCommand mySqlCommand = new MySqlCommand(query, minhaConexao.Start());

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                minhaConexao.Close();
            }
        }

    }
}
