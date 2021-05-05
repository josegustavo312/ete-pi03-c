<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina.Master" AutoEventWireup="true"
    CodeBehind="FrmProduto.aspx.cs" Inherits="ProjetoWeb1.FrmProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel3" runat="server" BackColor="#F3F3F3" HorizontalAlign="Left"
        Width="900px">
        <asp:Panel ID="Panel4" runat="server" BackColor="#F3F3F3" Height="40px" 
            HorizontalAlign="Center">
            <b>CADASTRO DE PRODUTOS&nbsp;&nbsp; </b>
            <asp:Image ID="Image2" runat="server" Height="40px" 
                ImageUrl="~/img/computador_icon.png" Width="40px" />
        </asp:Panel>
        <blockquote>
        Código de Barras:<br />
        <asp:TextBox ID="codigoBarraTextBox" runat="server" MaxLength="13" 
            Width="150px"></asp:TextBox>
            <br />
            <br />
            Referência:<br />
            <asp:TextBox ID="referenciaTextBox" runat="server" Width="350px"></asp:TextBox>
        <br />
            <br />
            Descrição:<br />
        <asp:TextBox ID="nomeTextBox" runat="server" Width="525px"></asp:TextBox>
        <br />
        <br />
            Preço: <span style="padding-left:365px"> Estoque </span><br />
            <asp:TextBox ID="precoTextBox" runat="server" Width="300px"></asp:TextBox>
            <span style="padding-left:100px">
            <asp:TextBox ID="estoqueTextBox" runat="server" Width="128px"></asp:TextBox>
            </span>
        <br />
            <br />
        <asp:Button ID="limparButton" runat="server" Text="Limpar" 
            onclick="limparButton_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="excluirButton" runat="server" Text="Excluir" 
            onclick="excluirButton_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="alterarButton" runat="server" Text="Alterar" 
            onclick="alterarButton_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="enviarButton" runat="server" OnClick="enviarButton_Click" Text="Cadastrar"
            Width="100px" />
            <br />
            <br />
            Pesquisar:<br />
            <asp:TextBox ID="pesquisarTextBox" runat="server" Width="203px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="pesquisarButton" runat="server" Text="Buscar" 
                onclick="pesquisarButton_Click" />
        </blockquote>
        <center>
        <asp:GridView ID="produtoGridView" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" GridLines="Vertical" 
                onrowcommand="produtoGridView_RowCommand">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" HeaderText="Seleção" />
                <asp:BoundField DataField="idproduto" HeaderText="ID" 
                    SortExpression="idproduto" />
                <asp:BoundField DataField="codBarra" HeaderText="Código" 
                    SortExpression="codBarra" />
                <asp:BoundField DataField="referencia" HeaderText="Refência" 
                    SortExpression="referencia" />
                <asp:BoundField DataField="descricao" HeaderText="Descrição" 
                    SortExpression="descricao" />
                <asp:BoundField DataField="estoque" HeaderText="Estoque" 
                    SortExpression="estoque" />
                <asp:BoundField DataField="preco" HeaderText="Preço" SortExpression="preco" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        </center>
    </asp:Panel>
</asp:Content>
