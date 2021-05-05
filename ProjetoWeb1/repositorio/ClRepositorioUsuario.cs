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
    public class ClRepositorioUsuario : ClUsuario
    {
        static List<ClUsuario> listaUsuarios = new List<ClUsuario>();
                
        public string inserir(ClUsuario objClUsuario)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "INSERT INTO usuario (nome, dataNasc, sexo, email, login, senha, mae, telefone, cpf, uf, cidade, bairro, logradouro, numero)" +
            "VALUES ('" + objClUsuario.Nome + "', '" + objClUsuario.DataNascimento + "', '" + objClUsuario.Sexo + "', '" + objClUsuario.Email + "', '" + objClUsuario.Login + "',"+
            "'" + objClUsuario.Senha + "', '" + objClUsuario.Mae + "', '" + objClUsuario.Telefone + "', '" + objClUsuario.Cpf + "', '" + objClUsuario.Uf + "',  '" + objClUsuario.Cidade + "'," +
            "'" + objClUsuario.Bairro + "','" + objClUsuario.Logradouro + "', '" + objClUsuario.Numero + "')";

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

        public string alterar(ClUsuario objClUsuario)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "UPDATE USUARIO SET NOME = '" + objClUsuario.Nome + "', DATANASC = '" + objClUsuario.DataNascimento + "'," +
                                "SEXO = '" + objClUsuario.Sexo + "', EMAIL = '" + objClUsuario.Email + "', LOGIN = '" + objClUsuario.Login + "'," +
                                "SENHA = '" + objClUsuario.Senha + "', MAE = '" + objClUsuario.Mae + "', TELEFONE = '" + objClUsuario.Telefone + "'," +
                                "CPF = '" + objClUsuario.Cpf + "', UF = '" + objClUsuario.Uf + "', CIDADE = '" + objClUsuario.Cidade + "'," +
                                "BAIRRO = '" + objClUsuario.Bairro + "'," + "LOGRADOURO = '" + objClUsuario.Logradouro + "', NUMERO = '" + objClUsuario.Numero + "'" +
                                "WHERE IDUSUARIO = '" + objClUsuario.IdUsuario + "'";

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

        public string excluir(ClUsuario objClUsuario)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "DELETE FROM USUARIO WHERE IDUSUARIO = '" + objClUsuario.IdUsuario + "'";

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

        public DataTable retornar(ClUsuario objClUsuario)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "SELECT * FROM USUARIO WHERE IDUSUARIO = '" + objClUsuario.IdUsuario + "'";

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

        public DataTable retornarLogin(ClUsuario objClUsuario)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "SELECT * FROM USUARIO WHERE LOGIN = '" + objClUsuario.Login + "' AND SENHA = '" + objClUsuario.Senha + "'";

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


        public DataTable retornarNome(ClUsuario objClUsuario)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "SELECT * FROM USUARIO WHERE NOME LIKE '%" + objClUsuario.Nome + "%'";

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
            string strComando = "SELECT * FROM USUARIO";

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