<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 679px; position: absolute; right: 424px; left: 398px;" Text="Cancel" height="35px" width="68px" OnClick="btnCancel_Click" />
        </p>
        <p>
            <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 49px; top: 84px; position: absolute; right: 852px; height: 27px;" Text="Product ID :" width="165px"></asp:Label>
            <asp:Label ID="lblCompany" runat="server" style="z-index: 1; left: 46px; top: 138px; position: absolute; bottom: 719px" Text="Company :"></asp:Label>
        </p>
        &nbsp;<div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <p>
            &nbsp;&nbsp;</p>
        <asp:Label ID="lblModelname" runat="server" style="z-index: 1; left: 47px; top: 187px; position: absolute; height: 27px;" Text="Model Name :" width="165px"></asp:Label>
        <asp:Label ID="lblRam" runat="server" style="z-index: 1; left: 48px; top: 243px; position: absolute" Text="Ram :" height="27px" width="165px"></asp:Label>
        <asp:Label ID="lblInternalStorage" runat="server" style="z-index: 1; left: 42px; top: 296px; position: absolute" Text="Internal Storage :"></asp:Label>
        <asp:Label ID="lblDisplay" runat="server" style="z-index: 1; left: 45px; top: 348px; position: absolute" Text="Display :" height="27px" width="165px"></asp:Label>
        <asp:Label ID="lblCamera" runat="server" style="z-index: 1; left: 43px; position: absolute; top: 405px" Text="Camera :" height="27px" width="165px"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 42px; top: 558px; position: absolute" Text="Price :" height="27px" width="165px"></asp:Label>
        <asp:Label ID="lblSimType" runat="server" style="z-index: 1; left: 42px; top: 506px; position: absolute; right: 865px" Text="Sim Type :" height="27px" width="165px"></asp:Label>
        <asp:Label ID="lblNetworkType" runat="server" style="z-index: 1; left: 42px; top: 452px; position: absolute; right: 829px; height: 27px;" Text="Network Type :" width="165px"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 45px; top: 612px; position: absolute" Text="Quantity :" height="27px" width="165px"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; top: 90px; position: absolute; width: 254px; left: 237px"></asp:TextBox>
        <asp:TextBox ID="txtCompany" runat="server" style="z-index: 1; left: 237px; top: 136px; position: absolute; width: 254px"></asp:TextBox>
        <asp:TextBox ID="txtModelName" runat="server" style="z-index: 1; left: 236px; top: 193px; position: absolute; width: 257px"></asp:TextBox>
        <asp:TextBox ID="txtRam" runat="server" style="z-index: 1; left: 235px; top: 246px; position: absolute; width: 258px"></asp:TextBox>
        <asp:TextBox ID="txtInternalStorage" runat="server" style="z-index: 1; left: 237px; top: 297px; position: absolute; width: 254px"></asp:TextBox>
        <asp:TextBox ID="txtDisplay" runat="server" style="z-index: 1; left: 238px; top: 350px; position: absolute; width: 251px"></asp:TextBox>
        <asp:TextBox ID="txtCamera" runat="server" style="z-index: 1; left: 240px; top: 403px; position: absolute; width: 248px"></asp:TextBox>
        <asp:TextBox ID="txtNetworkType" runat="server" style="z-index: 1; left: 243px; top: 454px; position: absolute; width: 242px"></asp:TextBox>
        <asp:TextBox ID="txtSimType" runat="server" style="z-index: 1; left: 244px; top: 506px; position: absolute; width: 240px"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 242px; top: 554px; position: absolute; width: 243px"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 241px; top: 616px; position: absolute; width: 245px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 95px; top: 675px; position: absolute; bottom: 182px"></asp:Label>
        <asp:Button ID="btnDone" runat="server" OnClick="btnDone_Click" style="z-index: 1; left: 269px; top: 676px; position: absolute; height: 38px; width: 72px;" Text="Done" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 586px; top: 85px; position: absolute" Text="Find" />
    </form>
</body>
</html>
