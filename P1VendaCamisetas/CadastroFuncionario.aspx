<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroFuncionario.aspx.cs" Inherits="P1VendaCamisetas.CadastroFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCadastroFuncionario" runat="server" Font-Bold="True" Font-Italic="True" Text="CADASTRO FUNCIONÁRIO"></asp:Label>
        </div>
        <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server" style="margin-left: 36px; margin-top: 21px" Width="172px"></asp:TextBox>
        <asp:Button ID="btnSalvar" runat="server" Height="37px" OnClick="btnSalvar_Click" style="margin-left: 228px; margin-top: 10px" Text="Salvar" Width="103px" />
        <p>
            <asp:Label ID="lblTelefone" runat="server" Text="Telefone"></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server" style="margin-left: 22px" Width="167px"></asp:TextBox>
            <asp:Button ID="btnAdicionar" runat="server" Height="32px" OnClick="btnAdicionar_Click" style="margin-left: 232px" Text="Adicionar Venda" Width="106px" PostBackUrl="~/CadastrarVenda.aspx" />
        </p>
        <asp:Label ID="lblEndereco" runat="server" Text="Endereço"></asp:Label>
        <asp:TextBox ID="txtEndereco" runat="server" style="margin-left: 17px" Width="165px"></asp:TextBox>
        <p>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </p>
        <asp:GridView ID="GVFuncionario" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="151px" style="margin-top: 13px" Width="526px">
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
