using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWeb1.classes
{
    public class ClVenda
    {
        int idVenda;

        public int IdVenda
        {
            get { return idVenda; }
            set { idVenda = value; }
        }

        int idcliente;

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}