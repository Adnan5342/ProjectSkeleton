<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" />
        <p>
        <asp:Label ID="lbl" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 635px; top: 170px; position: absolute" Text="Login"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblUsername" runat="server" Font-Size="X-Large" style="z-index: 1; left: 476px; top: 235px; position: absolute" Text="Username:"></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="txtUsername" runat="server" Font-Size="X-Large" style="z-index: 1; left: 589px; top: 231px; position: absolute; width: 260px"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="lblPassword" runat="server" Font-Size="X-Large" style="z-index: 1; left: 480px; top: 285px; position: absolute" Text="Password:"></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="txtPassword" runat="server" Font-Size="X-Large" style="z-index: 1; left: 589px; top: 279px; position: absolute; width: 260px" height="33px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
