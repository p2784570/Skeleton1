<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="UserRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 22px;
        }
        .form-control {
            margin-left: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div>
            <h2>Register</h2>
            <div>
                <asp:Label runat="server" AssociatedControlID="txtFirstName">First Name:</asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" required></asp:TextBox> <br> <br />
            </div>
            <div>
                <asp:Label runat="server" AssociatedControlID="txtLastName">Last Name:</asp:Label>
                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" required></asp:TextBox>  <br> <br />
           <div>
                <asp:Label runat="server" AssociatedControlID="txtEmail">Email:</asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" required></asp:TextBox>   <br> <br />
            </div>
        <div>
                <asp:Label runat="server" AssociatedControlID="txtPhone">Phone:</asp:Label>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" required></asp:TextBox>   <br> <br />
            </div>
        <div>
                <asp:Label runat="server" AssociatedControlID="txtAddress">Address:</asp:Label>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" required></asp:TextBox>   <br> <br />
            </div>
        <div>
                <asp:Label runat="server" AssociatedControlID="txtCity">City:</asp:Label>
                <asp:TextBox ID="txtCity" runat="server" CssClass="form-control" required></asp:TextBox>   <br> <br />
            </div>
        <div>

                <asp:Label runat="server" AssociatedControlID="txtState">State:</asp:Label>
                <asp:TextBox ID="txtState" runat="server" CssClass="form-control" required></asp:TextBox>   <br> <br />
            </div>

            <div>
         <asp:Label runat="server" AssociatedControlID="txtCounty">County:</asp:Label>
         <asp:TextBox ID="txtCounty" runat="server" CssClass="form-control" required></asp:TextBox>   <br> <br />
     </div>
            <div>
         <asp:Label runat="server" AssociatedControlID="txtPassword">Password:</asp:Label>
         <asp:TextBox ID="txtpassword" runat="server" CssClass="form-control" required></asp:TextBox>   <br> <br />
     </div>
            <div>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
            
            <div>
                <asp:HyperLink ID="lnkLogin" runat="server" NavigateUrl="~/Login.aspx" Text="Already have an account? Login here." />
            </div>

























          

























            

























          

























        </div>
      

        


        

    </form>
  
</body>
</html>
