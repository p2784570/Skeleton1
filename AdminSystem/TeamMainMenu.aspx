<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 272px; top: 83px; position: absolute; height: 36px; width: 246px" Text="Mobile Store Main Menu"></asp:Label>
            <asp:Button ID="btnCustomers" runat="server" OnClick="btnCustomers_Click" style="z-index: 1; left: 113px; top: 260px; position: absolute; height: 48px; width: 151px" Text="Customers" />
            <asp:Button ID="btnProducts" runat="server" OnClick="btnProducts_Click" style="z-index: 1; left: 322px; top: 258px; position: absolute; height: 50px; width: 151px; right: 417px" Text="Products" />
            <asp:Button ID="btnSales" runat="server" OnClick="btnSales_Click" style="z-index: 1; top: 256px; position: absolute; left: 530px; height: 50px; width: 150px" Text="Sales" />
            <asp:Button ID="btnManageAccount" runat="server" OnClick="btnManageAccount_Click" style="z-index: 1; top: 350px; position: absolute; left: 322px; height: 50px; width: 150px" Text="Manage Account" />
        </div>
    </form>
</body>
</html>
