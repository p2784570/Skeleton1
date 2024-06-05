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
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <table>
                <tr>
                    <td>Email:</td>
                    <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>