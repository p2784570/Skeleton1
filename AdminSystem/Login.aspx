<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login</h2>
            <div>
                <asp:Label runat="server" AssociatedControlID="txtEmail">Email:</asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" required></asp:TextBox>
            </div>
            <div>
                <asp:Label runat="server" AssociatedControlID="txtPassword">Password:</asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" required></asp:TextBox>
            </div>
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
            <div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </div>
            <div>
                <asp:HyperLink ID="lnkRegister" runat="server" NavigateUrl="~/Register.aspx" Text="Don't have an account? Register here." />
            </div>
        </div>
    </form>
</body>
</html>