using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWeb1.classes
{
    public class ClProduto
    {
        int idProduto;

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }

        string codigoBarra;

        public string CodigoBarra
        {
            get { return codigoBarra; }
            set { codigoBarra = value; }
        }

        string referencia;

        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        double preco;

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        double estoque;

        public double Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

    }
}