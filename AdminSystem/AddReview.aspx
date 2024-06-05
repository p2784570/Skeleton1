<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddReview.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Add Review</title>
    <script type="text/javascript">
        function confirmLogout() {
            return confirm("Are you sure you want to log out?");
        }
    </script>
    <style>
        .logout-button {
            position: absolute;
            top: 10px;
            right: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" CssClass="logout-button" />
            <h2>Add Review</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <table>
                <tr>
                    <td>Product ID:</td>
                    <td><asp:TextBox ID="txtProductID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Rating (1-5):</td>
                    <td><asp:TextBox ID="txtRating" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Comment:</td>
                    <td><asp:TextBox ID="txtComment" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnSubmitReview" runat="server" Text="Submit Review" OnClick="btnSubmitReview_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
