<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" style="z-index: 1; left: 23px; top: 34px; position: absolute; width: 1px" />
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" />
        <p>
        <asp:Label ID="lblSignUp" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 727px; top: 161px; position: absolute; right: 486px;" Text="Sign Up"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" Font-Size="X-Large" style="z-index: 1; left: 583px; top: 229px; position: absolute" Text="Username:"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" Font-Size="X-Large" style="z-index: 1; left: 908px; top: 229px; position: absolute" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" Font-Size="X-Large" style="z-index: 1; left: 833px; top: 264px; position: absolute; width: 205px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" Font-Size="X-Large" style="z-index: 1; left: 733px; top: 321px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" Font-Size="X-Large" style="z-index: 1; left: 528px; top: 264px; position: absolute; width: 205px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtPassword" runat="server" Font-Size="X-Large" style="z-index: 1; left: 676px; top: 355px; position: absolute; width: 205px"></asp:TextBox>
        <p>
            <asp:Button ID="btnCreateAccount" runat="server" Font-Size="X-Large" style="z-index: 1; left: 684px; top: 428px; position: absolute; width: 197px" Text="Create Account" />
        </p>
    </form>
</body>
</html>
