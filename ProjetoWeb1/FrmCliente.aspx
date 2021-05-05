<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina.Master" AutoEventWireup="true" CodeBehind="FrmCliente.aspx.cs" Inherits="ProjetoWeb1.FrmCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel3" runat="server" BackColor="#F3F3F3" 
        HorizontalAlign="Left" Width="900px">
        <br />
        <center>
            <b>CADASTRO DE CLIENTE</b>&nbsp;&nbsp;&nbsp;<asp:Image ID="users" 
                runat="server" Height="29px" 
            ImageUrl="~/img/cliente.png" Width="46px" />
        </center>
        <br />
        <blockquote>
        Nome: <span style="padding-left:340px"> &nbsp; Email: </span><br />
        <asp:TextBox ID="nomeTextBox" runat="server" Width="310px"></asp:TextBox>
        <span style="padding-left:75px">
        <asp:TextBox ID="emailTextBox" runat="server" Width="280px"></asp:TextBox>
        </span>
        <br />
        <br />
            Data de Nascimento:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sexo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            &nbsp; Nome da Mãe:<br />
            <asp:TextBox ID="dataTextBox" runat="server" Width="170px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="mRadioButton" runat="server" GroupName="sexo" Text="M" />
        &nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="fRadioButton" runat="server" GroupName="sexo" Text="F" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="maeTextBox" runat="server" Width="310px"></asp:TextBox>
            <br />
            <br />
            Telefone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; CPF:<br />
        <asp:TextBox ID="telefoneTextBox" runat="server" Width="150px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="cpfTextBox" runat="server" Width="161px"></asp:TextBox>
            <br />
        <br />
            Cidade:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; UF:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            &nbsp;&nbsp;&nbsp; Bairro:<br />
            <asp:TextBox ID="cidadeTextBox" runat="server" Width="220px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ufTextBox" runat="server" Width="38px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="bairroTextBox" runat="server" Width="220px"></asp:TextBox>
        <br />
            <br />
            Logradouro<span style="padding-left:230px">&nbsp;&nbsp; Nº </span><br />
        <asp:TextBox ID="logradouroTextBox" runat="server" Width="270px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="numeroTextBox" runat="server" Width="70px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="limparButton" runat="server" onclick="limparButton_Click" 
            Text="Limpar" />
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="excluirButton" runat="server" Text="Excluir" 
                onclick="excluirButton_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="alterarButton" runat="server" onclick="alterarButton_Click" 
                Text="Alterar" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="enviarButton" runat="server" onclick="enviarButton_Click" 
            Text="Cadastrar" Width="100px" />
            <br />
            <br />
            Pesquisar:<br />
            <asp:TextBox ID="pesquisarTextBox" runat="server" Width="232px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="pesquisarButton" runat="server" onclick="pesquisarButton_Click" 
                Text="Buscar" />
        </blockquote>
        <center>
        <asp:GridView ID="clienteGridView" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" GridLines="Vertical" 
            onrowcommand="clienteGridView_RowCommand" DataKeyNames="idcliente">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" HeaderText="Seleção" />
                <asp:BoundField HeaderText="ID" DataField="idcliente" 
                    SortExpression="idcliente" />
                <asp:BoundField HeaderText="Nome" DataField="nome" SortExpression="nome" />
                <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                <asp:BoundField HeaderText="CPF" DataField="cpf" SortExpression="cpf" />
                <asp:BoundField HeaderText="Telefone" DataField="telefone" 
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
    </asp:Panel>
</asp:Content>
