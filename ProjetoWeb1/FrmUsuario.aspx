<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina.Master" AutoEventWireup="true" CodeBehind="FrmUsuario.aspx.cs" Inherits="ProjetoWeb1.FrmFuncionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Left" 
        Width="900px" BackColor="#F3F3F3">
        <br />
        <center><b> CADASTRO USUÁRIO&nbsp;&nbsp; </b>
            <asp:Image ID="Image2" runat="server" Height="37px" ImageUrl="~/img/user.png" 
                Width="40px" />
        </center>
        <blockquote>
        Nome: <span style="padding-left:340px"> Email: </span><br />
        <asp:TextBox ID="nomeTextBox" runat="server" Width="300px"></asp:TextBox>
        <span style="padding-left:75px">
            <asp:TextBox ID="emailTextBox" runat="server" Width="280px"></asp:TextBox>
        </span>
        <br />
        <br />
        Data de Nascimento:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sexo:<br />
        <asp:TextBox ID="dataTextBox" runat="server" Width="170px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="mRadioButton" runat="server" Text="M" GroupName="sexo" />
        &nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="fRadioButton" runat="server" Text="F" GroupName="sexo" />
        <br />
            <br />
            Login: <span style="padding-left:210px">Senha:</span><br />
        <asp:TextBox ID="loginTextBox" runat="server" Width="200px"></asp:TextBox>
        <span style="padding-left:45px">
            <asp:TextBox ID="senhaTextBox" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
        </span>
        <br />
        <br />
        Nome da Mãe:<br />
        <asp:TextBox ID="maeTextBox" runat="server" Width="310px"></asp:TextBox>
        <br />
        <br />
        Telefone: <span style="padding-left:155px">CPF:</span><br />
        <asp:TextBox ID="telefoneTextBox" runat="server" Width="150px"></asp:TextBox>
        <span style="padding-left:60px">
            <asp:TextBox ID="cpfTextBox" runat="server" Width="161px"></asp:TextBox>
        </span>
        <br />
        <br />
            Cidade:<span style="padding-left:225px">UF:</span><span style="padding-left:130px">Bairro:</span><br />
        <asp:TextBox ID="cidadeTextBox" runat="server" Width="220px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ufTextBox" runat="server" Width="36px"></asp:TextBox>
        <span style="padding-left:110px">

            <asp:TextBox ID="bairroTextBox" runat="server" Width="220px"></asp:TextBox>

        </span>
        <br />
        <br />
            Logradouro:<span style="padding-left:237px"> Nº </span><br />
        <asp:TextBox ID="logradouroTextBox" runat="server" Width="270px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="numeroTextBox" runat="server" Width="70px"></asp:TextBox>
        <br />
            <br />
            <span>
            <asp:Button ID="limparButton" runat="server" onclick="limparButton_Click" 
                Text="Limpar" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Button ID="excluirButton" runat="server" Text="Excluir" 
                onclick="excluirButton_Click" />
            <span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="alterarButton" runat="server" Text="Alterar" 
                onclick="alterarButton_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="enviarButton" runat="server" onclick="enviarButton_Click" 
                Text="Cadastrar" />
            <br />
            <br />
            Pesquisar:<br />
            </span>
            <asp:TextBox ID="pesquisarTextBox" runat="server" Width="225px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="pesquisarButton" runat="server" onclick="pesquisarButton_Click" 
                Text="Buscar" />
        </blockquote>
        <br/><center>
        <asp:GridView ID="usuarioGridView" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" GridLines="Vertical" Width="684px" 
                DataKeyNames="idusuario" onrowcommand="usuarioGridView_RowCommand">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" HeaderText="Seleção" />
                <asp:BoundField DataField="idusuario" HeaderText="ID" 
                    SortExpression="idusuario" ReadOnly="True" />
                <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                <asp:BoundField DataField="cpf" HeaderText="CPF" 
                    SortExpression="cpf" />
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
    </asp:Panel>
</asp:Content>
