<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSignInPage" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Sign In Page"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 12px; top: 78px; position: absolute" Text="Username: "></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 12px; top: 99px; position: absolute; width: 180px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 14px; top: 136px; position: absolute" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 14px; top: 158px; position: absolute" width="180px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 17px; top: 201px; position: absolute" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 16px; top: 219px; position: absolute; width: 180px" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" style="z-index: 1; left: 19px; top: 258px; position: absolute" Text="Sign in" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 335px; position: absolute"></asp:Label>
        <asp:Button ID="btnRegister" runat="server" BorderStyle="None" OnClick="btnRegister_Click" style="z-index: 1; left: 19px; top: 290px; position: absolute; width: 169px" Text="No account? Register now!" />
        <p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 265px; top: 41px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
    </form>
</body>
</html>
