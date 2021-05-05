<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina.Master" AutoEventWireup="true" CodeBehind="ModuloVenda.aspx.cs" Inherits="ProjetoWeb1.ModuloVenda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="vendaPanel" runat="server" HorizontalAlign="Left" 
        Width="900px" BackColor="#F3F3F3">
        <center>
        <b> 
            MÓDULO DE VENDA&nbsp; </b>
            <asp:Image ID="Image5" runat="server" ImageUrl="~/img/pedido.png" />
            <br />
        </center>
        <blockquote>
            <b>Cliente:</b><br />
        <asp:TextBox ID="clientePTextBox" runat="server" Width="342px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="clientePButton" runat="server" Text="Pesquisar" 
                onclick="clientePButton_Click" />
            <br />
            <br />
            <center>
            <asp:GridView ID="clienteGridView" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" GridLines="Vertical" 
                onrowcommand="clienteGridView_RowCommand">
                <AlternatingRowStyle BackColor="Gainsboro" />
                <Columns>
                    <asp:CommandField HeaderText="Seleção" ShowSelectButton="True" />
                    <asp:BoundField DataField="idcliente" HeaderText="ID" 
                        SortExpression="idcliente" />
                    <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                    <asp:BoundField DataField="cpf" HeaderText="CPF" SortExpression="cpf" />
                    <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                    <asp:BoundField DataField="telefone" HeaderText="Telefone" 
                        SortExpression="telefone" />
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
            <br />
            <b>Produto Código:</b><br />
            <asp:TextBox ID="produtoPTextBox" runat="server" Width="342px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="produtoPButton" runat="server" Text="Pesquisar" 
                onclick="produtoPButton_Click" />
            <br />
            <br />
            <center>
            <asp:GridView ID="produtoGridView" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" GridLines="Vertical" 
                onrowcommand="produtoGridView_RowCommand">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:CommandField HeaderText="Seleção" ShowSelectButton="True" />
                    <asp:BoundField DataField="idproduto" HeaderText="ID" 
                        SortExpression="idproduto" />
                    <asp:BoundField DataField="codBarra" HeaderText="Código" 
                        SortExpression="codBarra" />
                    <asp:BoundField DataField="referencia" HeaderText="Referência" 
                        SortExpression="referencia" />
                    <asp:BoundField DataField="estoque" HeaderText="Estoque" 
                        SortExpression="estoque" />
                    <asp:BoundField DataField="preco" HeaderText="Valor" SortExpression="preco" />
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
            <br />
            <b>Cliente:<br />
            <asp:TextBox ID="clienteTextBox" runat="server" Width="342px"></asp:TextBox>
            <br />
            <br />
            Produto: <span style="padding-left:340px"> Quantidade </span></b><br />
            <asp:TextBox ID="produtoAddTextBox" runat="server" Width="362px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="quantTextBox" runat="server" Width="86px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="addButton" runat="server" onclick="addButton_Click" 
                Text="Adicionar" />
            <br />
            <br />
            <b>Produtos:</b><br />
            <asp:ListBox ID="vendaListBox" runat="server" Height="148px" Width="605px">
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="removerButton" runat="server" onclick="removerButton_Click" 
                Text="Remover" />
            <br />
            <br />
            TOTAL:<br /> R$:
            <asp:Label ID="totalLabel" runat="server" Text="__"></asp:Label>
            <br />
            <br />
            VALOR PAGO:<br />
            <asp:TextBox ID="pagoTextBox" runat="server" Width="150px"></asp:TextBox>
            <br />
            <br />
            Troco<br /> R$:
        <asp:Label ID="trocoLabel" runat="server" Text="__"></asp:Label>
        <br />
        <br />
        <asp:Button ID="cupomButton" runat="server" Text="Fechar Venda" 
                onclick="cupomButton_Click" />
        </blockquote>
        <br />
        <center>
            Nota Fiscal<br /> SOFT F5 - Atualizando sua Empresa<br /> Av. Fernado Cerqueira 
            Cesar Coimbra, 398<br /> Limeiroeiro - PE<br /> CEP: 29164-230<br /> (81) 3628-2342 / 9782-1254<br />
            <br />
            <asp:ListBox ID="cupomListBox" runat="server" Height="220px" Width="316px">
            </asp:ListBox>
            <br />
            <br />
            Total da Compra: R$:
            <asp:Label ID="totalCupomLabel" runat="server" Text="__"></asp:Label>
            <br />
            <br />
            Agradecemos a sua preferência<br /> Volte Sempre!<br />
        </center>
        <br />
    </asp:Panel>
</asp:Content>
