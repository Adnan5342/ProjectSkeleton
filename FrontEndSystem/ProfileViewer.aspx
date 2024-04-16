<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProfileViewer.aspx.cs" Inherits="ProfileViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 285px; top: 149px; position: absolute" Text="Your username: "></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 233px; top: 179px; position: absolute; width: 200px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 300px; top: 213px; position: absolute" Text="Your email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" height="22px" style="z-index: 1; left: 237px; top: 241px; position: absolute" width="200px"></asp:TextBox>
    </form>
</body>
</html>
