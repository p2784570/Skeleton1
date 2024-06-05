<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 352px; top: 491px; position: absolute; height: 41px; width: 104px" Text="Delete" />
            <asp:ListBox ID="lstProductList" runat="server" style="z-index: 1; left: 10px; top: 24px; position: absolute; height: 446px; width: 533px" OnSelectedIndexChanged="lstProductList_SelectedIndexChanged"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 42px; top: 495px; position: absolute; height: 41px; width: 89px" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 197px; top: 496px; position: absolute; height: 42px; width: 83px" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 61px; top: 716px; position: absolute"></asp:Label>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 89px; top: 649px; position: absolute; height: 44px; width: 159px" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 298px; top: 650px; position: absolute; height: 44px; width: 159px" Text="Clear Filter" />
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 28px; top: 583px; position: absolute; height: 37px; width: 205px" Text="Enter Model Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 253px; top: 578px; position: absolute; height: 35px; width: 195px"></asp:TextBox>
    </form>
</body>
</html>
