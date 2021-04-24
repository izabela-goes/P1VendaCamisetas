<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="P1VendaCamisetas.CadastroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCadastroCliente" runat="server" Text="CADASTRO CLIENTE" Font-Bold="True" Font-Italic="True"></asp:Label>
        <p>
            <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" Height="16px" style="margin-left: 32px; margin-top: 0px" Width="218px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblTelefone" runat="server" Text="Telefone"></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server" style="margin-left: 16px" Width="222px"></asp:TextBox>
            <asp:Button ID="btnSalvar" runat="server" Height="30px" style="margin-left: 128px" Text="Salvar" Width="167px" OnClick="btnSalvar_Click" />
        </p>
        <asp:Label ID="lblEndereco" runat="server" Text="Endereço"></asp:Label>
        <asp:TextBox ID="txtEndereco" runat="server" style="margin-left: 10px" Width="221px"></asp:TextBox>
        <asp:Button ID="btnAdicionar" runat="server" Height="33px" style="margin-left: 123px" Text="Adicionar Funcionário" Width="166px" OnClick="btnAdicionar_Click" PostBackUrl="~/CadastroFuncionario.aspx" />
        <p><asp:Label ID="lblMsg" runat="server"></asp:Label></p>
        

        <asp:GridView ID="GVCliente" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" style="margin-top: 76px" Width="584px" Height="193px">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
    </form>
</body>
</html>
