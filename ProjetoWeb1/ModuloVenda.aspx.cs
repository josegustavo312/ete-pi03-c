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
    public partial class ModuloVenda : System.Web.UI.Page
    {
        ClCliente objClCliente = new ClCliente();
        ClProduto objClProduto = new ClProduto();
        ClVenda objClVenda = new ClVenda();
        ClItem objClItem = new ClItem();
        ClRepositorioCliente objClRepositorioCliente = new ClRepositorioCliente();
        ClRepositorioProduto objClRepositorioProduto = new ClRepositorioProduto();
        ClRepositorioVenda objClRepositorioVenda = new ClRepositorioVenda();
        ClRepositorioItem objClRepositorioItem = new ClRepositorioItem();
        static string idCliente;
        static string idProduto;
        static string codBarra;
        static string referencia;
        static string descricao;
        static string preco;
        static string estoque;
        static double total;
        static double totalTroco;
              
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void carregarClientes()
        {
            objClCliente.Nome = clientePTextBox.Text;
            clienteGridView.DataSource = objClRepositorioCliente.retornarNome(objClCliente);
            clienteGridView.DataBind();

        }

        public void carregarClientesTodos()
        {
            clienteGridView.DataSource = objClRepositorioCliente.retornarTodos();
            clienteGridView.DataBind();

        }

        public void carregarProdutos()
        {
            objClProduto.CodigoBarra = produtoPTextBox.Text;
            produtoGridView.DataSource = objClRepositorioProduto.retornarCodBarra(objClProduto);
            produtoGridView.DataBind();
        }

        public void carregarProdutosTodos()
        {
            produtoGridView.DataSource = objClRepositorioProduto.retornarTodos();
            produtoGridView.DataBind();
        }

        protected void clienteGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            objClCliente.IdCliente = Convert.ToInt32(clienteGridView.Rows[index].Cells[1].Text.ToString());

            DataTable tabela = objClRepositorioCliente.retornar(objClCliente);

            idCliente = tabela.Rows[0]["idcliente"].ToString();
            clienteTextBox.Text = tabela.Rows[0]["nome"].ToString();

        }

        protected void produtoGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            objClProduto.IdProduto = Convert.ToInt32(produtoGridView.Rows[index].Cells[1].Text.ToString());

            DataTable tabela = objClRepositorioProduto.retornar(objClProduto);

            idProduto = tabela.Rows[0]["idproduto"].ToString();
            codBarra = tabela.Rows[0]["codBarra"].ToString();
            referencia = tabela.Rows[0]["referencia"].ToString();
            descricao = tabela.Rows[0]["descricao"].ToString();
            preco = tabela.Rows[0]["preco"].ToString();
            estoque = tabela.Rows[0]["estoque"].ToString();
            produtoAddTextBox.Text = tabela.Rows[0]["referencia"].ToString();
            preco = tabela.Rows[0]["preco"].ToString();
        }

        protected void clientePButton_Click(object sender, EventArgs e)
        {
            objClCliente.Nome = clientePTextBox.Text;
            if (clientePTextBox.Text == "")
            {
                carregarClientesTodos();
            }

            else
            {
                carregarClientes();
            }
        }

        protected void produtoPButton_Click(object sender, EventArgs e)
        {
            objClProduto.CodigoBarra = produtoPTextBox.Text;
            if (produtoPTextBox.Text == "")
            {
                carregarProdutosTodos();
            }

            else
            {
                carregarProdutos();
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string marca = produtoAddTextBox.Text;
            double quant = Convert.ToDouble(quantTextBox.Text);
            double estoqueProduto = Convert.ToDouble(estoque);
            double precoProduto = Convert.ToDouble(preco);
            
            //calcular total
            double operacao = precoProduto * quant;

            total += operacao;

            totalTroco += operacao;

            totalLabel.Text = total.ToString();

            totalCupomLabel.Text = total.ToString();

            //adicionar no listbox venda
            int b = 1;
            for (int a = 0; a < b; a++)
            {
                vendaListBox.Items.Add(codBarra + " - " + marca + " - R$:." + precoProduto + ". - " + " Quant:." + quant + ". - Total:." + operacao);
            }

            //adicionar no listbox venda
            cupomListBox.Items.Add(codBarra + " - " + marca + " - R$:" + preco + " - " + quant);

            //Inserir Item
            objClItem.Idproduto = Convert.ToInt32(idProduto);
            objClItem.Quantidade = Convert.ToInt32(quantTextBox.Text);

            objClRepositorioItem.inserir(objClItem);

            //baixa do estoque

            objClRepositorioProduto.CodigoBarra = codBarra;

            double baixaEstoque = estoqueProduto - quant;

            objClRepositorioProduto.Estoque = Convert.ToInt32(baixaEstoque);

            objClRepositorioProduto.alterarQuant(objClRepositorioProduto);

            limparCamposAdd();
        }

        protected void cupomButton_Click(object sender, EventArgs e)
        {
            //calcular troco
            double troco = Convert.ToDouble(pagoTextBox.Text);

            troco -= totalTroco;

            trocoLabel.Text = troco.ToString();

            //ocultar botão add
            addButton.Visible = false;

            //Inserir Venda
            objClVenda.Idcliente = Convert.ToInt32(idCliente);
            objClVenda.Valor = Convert.ToDouble(totalCupomLabel.Text);

            objClRepositorioVenda.inserir(objClVenda);

            limparCampos();
        }

        public void limparCamposAdd()
        {
            produtoPTextBox.Text = "";
            produtoAddTextBox.Text = "";
            quantTextBox.Text = "";
            pagoTextBox.Text = "";
        }

        public void limparCampos()
        {
            clienteTextBox.Text = "";
            clientePTextBox.Text = "";
            produtoPTextBox.Text = "";
            produtoAddTextBox.Text = "";
            quantTextBox.Text = "";
            pagoTextBox.Text = "";
        }

        protected void removerButton_Click(object sender, EventArgs e)
        {
            string codigoAdd = vendaListBox.SelectedItem.Text.Substring(0, 13);
            int indice = vendaListBox.SelectedIndex;

            string[] remover = vendaListBox.SelectedItem.Text.Split('.');
            double precoRemover = Convert.ToDouble (remover[5]);

            total -= precoRemover;

            totalLabel.Text = total.ToString();

            totalCupomLabel.Text = total.ToString();

            double estoqueRemover = Convert.ToDouble(estoque);
            double quantRemover = Convert.ToDouble (remover[3]);
            double estoqueAdd = estoqueRemover + quantRemover;

            //estornar estoque
            
            objClRepositorioProduto.Estoque = estoqueAdd;
            objClRepositorioProduto.CodigoBarra = codigoAdd;
            objClRepositorioProduto.alterarQuant(objClRepositorioProduto);

            cupomListBox.Items.RemoveAt(indice);
            vendaListBox.Items.RemoveAt(indice);
        }
     }
}