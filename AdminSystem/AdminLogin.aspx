<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
        <asp:Label ID="lblSignInPage" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Admin Sign In Page"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 12px; top: 78px; position: absolute" Text="Email: "></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 12px; top: 152px; position: absolute" Text="Password: "></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 12px; top: 106px; position: absolute" width="180px"></asp:TextBox>
        </p>
        <p>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 12px; top: 180px; position: absolute; width: 180px" TextMode="Password"></asp:TextBox>
        </p>
        <p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 265px; top: 41px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <p>
        <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" style="z-index: 1; left: 12px; top: 222px; position: absolute" Text="Sign in" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 260px; position: absolute" Font-Bold="True"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
