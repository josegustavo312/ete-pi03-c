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
    public class ClRepositorioVenda
    {
        public string inserir(ClVenda objClVenda)
        {
            string strConexao = @"server=localhost;Persist Security Info=True;User Id=root;database=banco_projeto";
            string strComando = "INSERT INTO venda (idcliente, valor) VALUES ('" + objClVenda.Idcliente + "', '" + objClVenda.Valor + "')";

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