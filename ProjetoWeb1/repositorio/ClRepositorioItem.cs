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
    public class ClRepositorioItem
    {
        public string inserir(ClItem objClItem)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "INSERT INTO item (idvenda, idproduto, quantidade)" +
            " VALUES ('" + objClItem.Idvenda + "', '" + objClItem.Idproduto + "', '" + objClItem.Quantidade + "')";

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
    }
}