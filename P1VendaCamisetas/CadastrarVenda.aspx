<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarVenda.aspx.cs" Inherits="P1VendaCamisetas.CadastrarVenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCadastrarVenda" runat="server" Font-Bold="True" Font-Italic="True" Text="CADASTRAR VENDA"></asp:Label>
        </div>
        <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
        <asp:TextBox ID="txtDescricao" runat="server" style="margin-left: 53px; margin-top: 19px" Width="179px"></asp:TextBox>
        <asp:Button ID="btnSalvar" runat="server" Height="36px" OnClick="btnSalvar_Click" style="margin-left: 152px; margin-top: 0px" Text="Salvar" Width="143px" />
        <p>
            <asp:Label ID="lblModelo" runat="server" Text="Modelo"></asp:Label>
            <asp:TextBox ID="txtModelo" runat="server" style="margin-left: 66px" Width="174px"></asp:TextBox>
        </p>
        <asp:Label ID="lblPreco" runat="server" Text="Preço"></asp:Label>
        <asp:TextBox ID="txtPreco" runat="server" style="margin-left: 80px" Width="175px"></asp:TextBox>
        <p>
            <asp:Label ID="lblIdCliente" runat="server" Text="Id Cliente"></asp:Label>
            <asp:TextBox ID="txtIdCliente" runat="server" style="margin-left: 55px" Width="181px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblIdFuncionario" runat="server" Text="Id Funcionário"></asp:Label>
            <asp:TextBox ID="txtIdFuncionario" runat="server" style="margin-left: 27px" Width="171px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </p>
        <p>
            <asp:GridView ID="GVVenda" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="183px" style="margin-top: 0px" Width="584px">
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
        </p>
        <p>
            <asp:Button ID="btnVoltar" runat="server" Height="39px" OnClick="btnVoltar_Click" PostBackUrl="~/CadastroCliente.aspx" Text="Voltar Cliente" Width="96px" />
        </p>
    </form>
</body>
</html>
