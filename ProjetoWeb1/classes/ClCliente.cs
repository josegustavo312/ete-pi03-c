using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWeb1.classes
{
    public class ClCliente
    {
        int idCliente;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        string dataNascimento;

        public String DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        string mae;

        public string Mae
        {
            get { return mae; }
            set { mae = value; }
        }

        string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        string logradouro;

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

    }
}