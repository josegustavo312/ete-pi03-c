using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetoWeb1.classes;
using ProjetoWeb1.repositorio;
using System.Data;

namespace ProjetoWeb1
{
    public partial class FrmCliente : System.Web.UI.Page
    {
        ClCliente objClCliente = new ClCliente();
        ClRepositorioCliente objClRepositorioCliente = new ClRepositorioCliente();
        static string idCliente;

        protected void Page_Load(object sender, EventArgs e)
        {
            carregarClientes();

        }

        public void carregarClientes()
        {
            clienteGridView.DataSource = objClRepositorioCliente.retornarTodos();
            clienteGridView.DataBind();
           
        }

        protected void enviarButton_Click(object sender, EventArgs e)
        {
            objClRepositorioCliente.Nome = nomeTextBox.Text;
            objClRepositorioCliente.DataNascimento = dataTextBox.Text;
            if (mRadioButton.Checked == true)
            {
                objClRepositorioCliente.Sexo = "M";
            }
            else
            {
                objClRepositorioCliente.Sexo = "F";    
            }
            objClRepositorioCliente.Email = emailTextBox.Text;
            objClRepositorioCliente.Mae = maeTextBox.Text;
            objClRepositorioCliente.Telefone = telefoneTextBox.Text;
            objClRepositorioCliente.Cpf = cpfTextBox.Text;
            objClRepositorioCliente.Cidade = cidadeTextBox.Text;
            objClRepositorioCliente.Uf = ufTextBox.Text;
            objClRepositorioCliente.Bairro = bairroTextBox.Text;
            objClRepositorioCliente.Logradouro = logradouroTextBox.Text;
            objClRepositorioCliente.Numero = numeroTextBox.Text;

            objClRepositorioCliente.inserir(objClRepositorioCliente);

            carregarClientes();

            limparCampos();
        }
        
        public void limparCampos()
        {
            nomeTextBox.Text = "";
            dataTextBox.Text = "";
            emailTextBox.Text = "";
            maeTextBox.Text = "";
            telefoneTextBox.Text = "";
            cpfTextBox.Text = "";
            cidadeTextBox.Text = "";
            ufTextBox.Text = "";
            bairroTextBox.Text = "";
            logradouroTextBox.Text = "";
            numeroTextBox.Text = "";
        }

        protected void limparButton_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        protected void clienteGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            objClCliente.IdCliente = Convert.ToInt32(clienteGridView.Rows[index].Cells[1].Text.ToString());

            DataTable tabela = objClRepositorioCliente.retornar(objClCliente);

            idCliente = tabela.Rows[0]["idcliente"].ToString();
            nomeTextBox.Text = tabela.Rows[0]["nome"].ToString();
            emailTextBox.Text = tabela.Rows[0]["email"].ToString();
            dataTextBox.Text = tabela.Rows[0]["dataNasc"].ToString();
            string sexo = tabela.Rows[0]["sexo"].ToString();
            if (sexo.Equals("M"))
            {
                mRadioButton.Checked = true;
                fRadioButton.Checked = false;
            }
            else
            {
                fRadioButton.Checked = true;
                mRadioButton.Checked = false;
            }
            maeTextBox.Text = tabela.Rows[0]["mae"].ToString();
            cpfTextBox.Text = tabela.Rows[0]["cpf"].ToString();
            telefoneTextBox.Text = tabela.Rows[0]["telefone"].ToString();
            cidadeTextBox.Text = tabela.Rows[0]["cidade"].ToString();
            ufTextBox.Text = tabela.Rows[0]["uf"].ToString();
            bairroTextBox.Text = tabela.Rows[0]["bairro"].ToString();
            logradouroTextBox.Text = tabela.Rows[0]["logradouro"].ToString();
            numeroTextBox.Text = tabela.Rows[0]["numero"].ToString();
        }

        protected void alterarButton_Click(object sender, EventArgs e)
        {
            objClRepositorioCliente.IdCliente = Convert.ToInt32(idCliente);
            objClRepositorioCliente.Nome = nomeTextBox.Text;
            objClRepositorioCliente.DataNascimento = dataTextBox.Text;
            if (mRadioButton.Checked == true)
            {
                objClRepositorioCliente.Sexo = "M";
            }
            else
            {
                objClRepositorioCliente.Sexo = "F";
            }
            objClRepositorioCliente.Email = emailTextBox.Text;
            objClRepositorioCliente.Mae = maeTextBox.Text;
            objClRepositorioCliente.Telefone = telefoneTextBox.Text;
            objClRepositorioCliente.Cpf = cpfTextBox.Text;
            objClRepositorioCliente.Cidade = cidadeTextBox.Text;
            objClRepositorioCliente.Uf = ufTextBox.Text;
            objClRepositorioCliente.Bairro = bairroTextBox.Text;
            objClRepositorioCliente.Logradouro = logradouroTextBox.Text;
            objClRepositorioCliente.Numero = numeroTextBox.Text;

            objClRepositorioCliente.alterar(objClRepositorioCliente);

            carregarClientes();

            limparCampos();
        }

        protected void excluirButton_Click(object sender, EventArgs e)
        {
            objClCliente.IdCliente = Convert.ToInt32(idCliente);

            objClRepositorioCliente.excluir(objClCliente);

            carregarClientes();

            limparCampos();
        }

        protected void pesquisarButton_Click(object sender, EventArgs e)
        {
            objClCliente.Nome = pesquisarTextBox.Text;
            if (pesquisarTextBox.Text == "")
            {
                carregarClientes();
            }
            else
            {
                clienteGridView.DataSource = objClRepositorioCliente.retornarNome(objClCliente);
                clienteGridView.DataBind();
            }
        }
        
    }
}