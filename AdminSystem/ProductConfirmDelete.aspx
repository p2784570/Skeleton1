<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 107px; top: 59px; position: absolute; width: 488px" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 187px; top: 131px; position: absolute; height: 44px; width: 79px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 327px; top: 135px; position: absolute; height: 41px; width: 77px" Text="No" />
    </form>
</body>
</html>
