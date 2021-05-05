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
    public class ClRepositorioProduto: ClProduto
    {
        static List<ClProduto> listaProdutos = new List<ClProduto>();

        public string inserir(ClProduto objClProduto)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "INSERT INTO produto (codBarra, descricao, preco, estoque, referencia)" +
            "VALUES ('" + objClProduto.CodigoBarra + "', '" + objClProduto.Descricao + "', '" + objClProduto.Preco + "', '" + objClProduto.Estoque + "', '" + objClProduto.Referencia + "')";

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

        public string alterar(ClProduto objClProduto)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "UPDATE PRODUTO SET CODBARRA = '" + objClProduto.CodigoBarra + "', DESCRICAO = '" + objClProduto.Descricao + "'," +
                                "PRECO = '" + objClProduto.Preco + "', ESTOQUE = '" + objClProduto.Estoque + "', REFERENCIA = '" + objClProduto.Referencia + "'"  +
                                "WHERE IDPRODUTO = '" + objClProduto.IdProduto + "'";

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

        public string alterarQuant(ClProduto objClProduto)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "UPDATE PRODUTO SET ESTOQUE = '" + objClProduto.Estoque + "'" +
                                "WHERE CODBARRA = '" + objClProduto.CodigoBarra + "'";

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

        public string excluir(ClProduto objClProduto)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "DELETE FROM PRODUTO WHERE IDPRODUTO = '" + objClProduto.IdProduto + "'";

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
        
        public DataTable retornar(ClProduto objClProduto)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "SELECT * FROM PRODUTO WHERE IDPRODUTO = '" + objClProduto.IdProduto + "'";

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

        public DataTable retornarCodBarra(ClProduto objClProduto)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "SELECT * FROM PRODUTO WHERE CODBARRA = '" + objClProduto.CodigoBarra + "'";

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
            string strComando = "SELECT * FROM PRODUTO";

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