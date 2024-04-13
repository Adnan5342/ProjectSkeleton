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
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 450px; top: 141px; position: absolute" Text="Your username: "></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 394px; top: 162px; position: absolute; width: 200px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 463px; top: 208px; position: absolute" Text="Your email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" height="22px" style="z-index: 1; left: 394px; top: 230px; position: absolute" width="200px"></asp:TextBox>
    </form>
</body>
</html>
