using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoWeb1.classes;
using ProjetoWeb1.repositorio;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoWeb1.repositorio
{
    public class ClRepositorioCliente: ClCliente
    {
        static List<ClCliente> listaCliente = new List<ClCliente>();

        public string inserir(ClCliente objClCliente)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "INSERT INTO cliente (nome, dataNasc, sexo, email, mae, telefone, cpf, cidade, uf, bairro, logradouro, numero)" +
            "VALUES ('" + objClCliente.Nome + "', '" + objClCliente.DataNascimento + "', '" + objClCliente.Sexo + "', '" + objClCliente.Email + "', "+
            "'" + objClCliente.Mae + "', '" + objClCliente.Telefone + "', '" + objClCliente.Cpf + "',  '" + objClCliente.Cidade + "', '" + objClCliente.Uf + "'," +
            "'" + objClCliente.Bairro + "', '" + objClCliente.Logradouro + "', '" + objClCliente.Numero + "')";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlCommand comando = new MySqlCommand(strComando, conexao);

            try
            {
                conexao.Open();

                comando.ExecuteNonQuery();

                return "ok";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        public string alterar(ClCliente objClCliente)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "UPDATE CLIENTE SET NOME = '" + objClCliente.Nome + "', DATANASC = '" + objClCliente.DataNascimento + "'," +
                                "SEXO = '" + objClCliente.Sexo + "', EMAIL = '" + objClCliente.Email + "', MAE = '" + objClCliente.Mae + "', TELEFONE = '" + objClCliente.Telefone + "'," +
                                "CPF = '" + objClCliente.Cpf + "', UF = '" + objClCliente.Uf + "', BAIRRO = '" + objClCliente.Bairro + "'," +
                                "LOGRADOURO = '" + objClCliente.Logradouro + "', NUMERO = '" + objClCliente.Numero + "', CIDADE = '" + objClCliente.Cidade + "'" +
                                "WHERE IDCLIENTE = '" + objClCliente.IdCliente + "'";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlCommand comando = new MySqlCommand(strComando, conexao);

            try
            {
                conexao.Open();

                comando.ExecuteNonQuery();

                return "ok";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        public string excluir(ClCliente objClCliente)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "DELETE FROM CLIENTE WHERE IDCLIENTE = '" + objClCliente.IdCliente + "'";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlCommand comando = new MySqlCommand(strComando, conexao);

            try
            {
                conexao.Open();

                comando.ExecuteNonQuery();

                return "ok";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable retornar(ClCliente objClCliente)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "SELECT * FROM CLIENTE WHERE IDCLIENTE = '" + objClCliente.IdCliente + "'";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlCommand comando = new MySqlCommand(strComando, conexao);
            DataTable tabela = new DataTable();

            try
            {
                conexao.Open();

                MySqlDataReader retorno = comando.ExecuteReader();
                tabela.Load(retorno);

                return tabela;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable retornarNome(ClCliente objClCliente)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "SELECT * FROM CLIENTE WHERE NOME LIKE '%" + objClCliente.Nome + "%'";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlCommand comando = new MySqlCommand(strComando, conexao);
            DataTable tabela = new DataTable();

            try
            {
                conexao.Open();

                MySqlDataReader retorno = comando.ExecuteReader();
                tabela.Load(retorno);

                return tabela;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable retornarTodos()
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "SELECT * FROM CLIENTE";

            MySqlConnection conexao = new MySqlConnection(strConexao);
            MySqlCommand comando = new MySqlCommand(strComando, conexao);
            DataTable tabela = new DataTable();

            try
            {
                conexao.Open();

                MySqlDataReader retorno = comando.ExecuteReader();
                tabela.Load(retorno);

                return tabela;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}