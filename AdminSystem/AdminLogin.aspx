<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
        <asp:Label ID="lblSignInPage" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 17px; top: 126px; position: absolute" Text="Admin Sign In Page"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 17px; top: 164px; position: absolute" Text="Email: "></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 17px; top: 232px; position: absolute" Text="Password: "></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 17px; top: 192px; position: absolute" width="180px"></asp:TextBox>
        </p>
        <p>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 17px; top: 257px; position: absolute; width: 180px" TextMode="Password"></asp:TextBox>
        </p>
        <p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 17px; top: 19px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <p>
        <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" style="z-index: 1; left: 17px; top: 299px; position: absolute" Text="Sign in" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 347px; position: absolute" Font-Bold="True"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
