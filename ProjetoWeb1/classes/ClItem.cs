using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWeb1.classes
{
    public class ClItem
    {
        int iditem;

        public int Iditem
        {
            get { return iditem; }
            set { iditem = value; }
        }

        int idvenda;

        public int Idvenda
        {
            get { return idvenda; }
            set { idvenda = value; }
        }

        int idproduto;

        public int Idproduto
        {
            get { return idproduto; }
            set { idproduto = value; }
        }

        int quantidade;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
    }
}