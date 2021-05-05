using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetoWeb1.classes;
using ProjetoWeb1.repositorio;
using System.Data;
using System.Text;
using System.Security.Cryptography;

namespace ProjetoWeb1
{
    public partial class FrmFuncionario : System.Web.UI.Page
    {
        ClUsuario objClUsuario = new ClUsuario();
        ClRepositorioUsuario objClRepositorioUsuario = new ClRepositorioUsuario();
        static string idUsuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            carregarUsuario();
        }

        public void carregarUsuario()
        {
            usuarioGridView.DataSource = objClRepositorioUsuario.retornarTodos();
            usuarioGridView.DataBind();
        }

        protected void enviarButton_Click(object sender, EventArgs e)
        {
            objClUsuario.Cpf = cpfTextBox.Text;
            objClUsuario.Nome = nomeTextBox.Text;
            objClUsuario.DataNascimento = dataTextBox.Text;
            if (mRadioButton.Checked == true)
            {
                objClUsuario.Sexo = "M";
            }
            else
            {
                objClUsuario.Sexo = "F";    
            }
            objClUsuario.Email = emailTextBox.Text;
            objClUsuario.Login = loginTextBox.Text;
            objClUsuario.Senha = criptografar(senhaTextBox.Text);
            objClUsuario.Mae = maeTextBox.Text;
            objClUsuario.Telefone = telefoneTextBox.Text;
            objClUsuario.Uf = ufTextBox.Text;
            objClUsuario.Cidade = cidadeTextBox.Text;
            objClUsuario.Bairro = bairroTextBox.Text;
            objClUsuario.Logradouro = logradouroTextBox.Text;
            objClUsuario.Numero = numeroTextBox.Text;

            objClRepositorioUsuario.inserir(objClUsuario);
            
            carregarUsuario();

            limparCampos();
        }
        
        public void limparCampos()
        {
            nomeTextBox.Text = "";
            dataTextBox.Text = "";
            emailTextBox.Text = "";
            loginTextBox.Text = "";
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

        protected void usuarioGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            objClUsuario.IdUsuario = Convert.ToInt32(usuarioGridView.Rows[index].Cells[1].Text.ToString());

            DataTable tabela = objClRepositorioUsuario.retornar(objClUsuario);

            idUsuario = tabela.Rows[0]["idusuario"].ToString();
            nomeTextBox.Text = tabela.Rows[0]["nome"].ToString();
            emailTextBox.Text = tabela.Rows[0]["email"].ToString();
            dataTextBox.Text = tabela.Rows[0]["dataNasc"].ToString();
            string sexo = tabela.Rows[0]["sexo"].ToString();
            if ( sexo.Equals("M"))
            {
                mRadioButton.Checked = true;
                fRadioButton.Checked = false;
            }
            else
            {
                fRadioButton.Checked = true;
                mRadioButton.Checked = false;
            }
            loginTextBox.Text = tabela.Rows[0]["login"].ToString();
            senhaTextBox.Text = tabela.Rows[0]["senha"].ToString();
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
            objClUsuario.IdUsuario = Convert.ToInt32(idUsuario);
            objClUsuario.Cpf = cpfTextBox.Text;
            objClUsuario.Nome = nomeTextBox.Text;
            objClUsuario.DataNascimento = dataTextBox.Text;
            if (mRadioButton.Checked == true)
            {
                objClUsuario.Sexo = "M";
            }
            else
            {
                objClUsuario.Sexo = "F";
            }
            objClUsuario.Email = emailTextBox.Text;
            objClUsuario.Login = loginTextBox.Text;
            objClUsuario.Senha = criptografar(senhaTextBox.Text);
            objClUsuario.Mae = maeTextBox.Text;
            objClUsuario.Telefone = telefoneTextBox.Text;
            objClUsuario.Cidade = cidadeTextBox.Text;
            objClUsuario.Uf = ufTextBox.Text;
            objClUsuario.Bairro = bairroTextBox.Text;
            objClUsuario.Logradouro = logradouroTextBox.Text;
            objClUsuario.Numero = numeroTextBox.Text;

            objClRepositorioUsuario.alterar(objClUsuario);

            carregarUsuario();

            limparCampos();
        }

        protected void excluirButton_Click(object sender, EventArgs e)
        {
            objClUsuario.IdUsuario = Convert.ToInt32(idUsuario);

            objClRepositorioUsuario.excluir(objClUsuario);

            carregarUsuario();

            limparCampos();
        }

        protected void pesquisarButton_Click(object sender, EventArgs e)
        {
            objClUsuario.Nome = pesquisarTextBox.Text;
            if (pesquisarTextBox.Text == "")
            {
                carregarUsuario();
            }
            else
            {
                usuarioGridView.DataSource = objClRepositorioUsuario.retornarNome(objClUsuario);
                usuarioGridView.DataBind();
            }
        }


        private string criptografar(string senha)
        {
            MD5 md5 = MD5.Create();

            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(senha));

            StringBuilder cript = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                cript.Append(data[i].ToString("x2"));
            }

            return cript.ToString();
        }
                
    }
}
