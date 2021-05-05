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
    public partial class FrmProduto : System.Web.UI.Page
    {
        ClProduto objClProduto = new ClProduto();
        ClRepositorioProduto objClRepositorioProduto = new ClRepositorioProduto();
        static string idProduto;

        protected void Page_Load(object sender, EventArgs e)
        {
            carregarProdutos();
        }

        public void carregarProdutos()
        {
            produtoGridView.DataSource = objClRepositorioProduto.retornarTodos();
            produtoGridView.DataBind();
        }
        
        protected void enviarButton_Click(object sender, EventArgs e)
        {
            objClRepositorioProduto.CodigoBarra = codigoBarraTextBox.Text;
            objClRepositorioProduto.Referencia = referenciaTextBox.Text;
            objClRepositorioProduto.Descricao = nomeTextBox.Text;
            objClRepositorioProduto.Preco = Convert.ToDouble(precoTextBox.Text);
            objClRepositorioProduto.Estoque = Convert.ToInt32(estoqueTextBox.Text);

            objClRepositorioProduto.inserir(objClRepositorioProduto);

            carregarProdutos();

            limparCampos();
        }

        public void limparCampos()
        {
            codigoBarraTextBox.Text = "";
            referenciaTextBox.Text = "";
            nomeTextBox.Text = "";
            precoTextBox.Text = "";
            estoqueTextBox.Text = "";
        }

        protected void alterarButton_Click(object sender, EventArgs e)
        {
            objClRepositorioProduto.IdProduto = Convert.ToInt32(idProduto);
            objClRepositorioProduto.CodigoBarra = codigoBarraTextBox.Text;
            objClRepositorioProduto.Referencia = referenciaTextBox.Text;
            objClRepositorioProduto.Descricao = nomeTextBox.Text;
            objClRepositorioProduto.Preco = Convert.ToDouble(precoTextBox.Text);
            objClRepositorioProduto.Estoque = Convert.ToInt32(estoqueTextBox.Text);

            objClRepositorioProduto.alterar(objClRepositorioProduto);

            carregarProdutos();

            limparCampos();
        }

        protected void limparButton_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        protected void excluirButton_Click(object sender, EventArgs e)
        {
            objClProduto.IdProduto = Convert.ToInt32(idProduto);

            objClRepositorioProduto.excluir(objClProduto);

            carregarProdutos();

            limparCampos();
        }

        protected void produtoGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            objClProduto.IdProduto = Convert.ToInt32(produtoGridView.Rows[index].Cells[1].Text.ToString());

            DataTable tabela = objClRepositorioProduto.retornar(objClProduto);

            idProduto = tabela.Rows[0]["idproduto"].ToString();
            codigoBarraTextBox.Text = tabela.Rows[0]["codBarra"].ToString();
            referenciaTextBox.Text = tabela.Rows[0]["referencia"].ToString();
            nomeTextBox.Text = tabela.Rows[0]["descricao"].ToString();
            precoTextBox.Text = tabela.Rows[0]["preco"].ToString();
            estoqueTextBox.Text = tabela.Rows[0]["estoque"].ToString();
            
        }

        protected void pesquisarButton_Click(object sender, EventArgs e)
        {
            objClProduto.CodigoBarra = pesquisarTextBox.Text;
            if (pesquisarTextBox.Text == "")
            {
                carregarProdutos();
            }
            else
            {
                produtoGridView.DataSource = objClRepositorioProduto.retornarCodBarra(objClProduto);
                produtoGridView.DataBind();
            }
        }
                
    }
}