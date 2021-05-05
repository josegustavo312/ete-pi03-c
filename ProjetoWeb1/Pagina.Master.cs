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
    public partial class Pagina : System.Web.UI.MasterPage
    {
        ClUsuario objClUsuario = new ClUsuario();
        ClRepositorioUsuario objClRepositorioUsuario = new ClRepositorioUsuario();
        
        static bool status = false;
        static string usuario = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (status == false)
            {
                menuPanel.Visible = false;
                loginPanel.Visible = true;
                usuarioPanel.Visible = false;
                usuarioLabel.Text = usuario;
            }
            else
            {
                menuPanel.Visible = true;
                loginPanel.Visible = false;
                usuarioPanel.Visible = true;
                usuarioLabel.Text = usuario;
            }
        }

        protected void entrarButton_Click(object sender, EventArgs e)
        {
            objClUsuario.Login = loginTextBox.Text;
            objClUsuario.Senha = criptografar(senhaTextBox.Text);

            DataTable tabela = objClRepositorioUsuario.retornarLogin(objClUsuario);

            if (tabela != null && tabela.Rows.Count != 0)
            {
                menuPanel.Visible = true;
                loginPanel.Visible = false;
                usuarioPanel.Visible = true;
                usuario = tabela.Rows[0]["nome"].ToString();
                usuarioLabel.Text = usuario;
                status = true;                  
            }

            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OK", "alert('USUÁRIO E/OU SENHA INCORRETOS');", true);   
            }

        }

        protected void sairLinkButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            loginPanel.Visible = true;
            usuarioPanel.Visible = false;
            status = false;
            Response.Redirect("FrmIndex.aspx");
        }

        protected void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void cadastrarImageButton_Click(object sender, ImageClickEventArgs e)
        {
            submenuPanel.Visible = true;
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