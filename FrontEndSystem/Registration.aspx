<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSignUpForm" runat="server" Font-Bold="True" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Sign Up Form"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 14px; top: 67px; position: absolute" Text="Username: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 14px; top: 90px; position: absolute; width: 176px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 17px; top: 120px; position: absolute" Text="Email: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 16px; top: 143px; position: absolute" width="176px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 19px; top: 181px; position: absolute" Text="Password: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 18px; top: 204px; position: absolute" width="176px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblConfirmPassword" runat="server" style="z-index: 1; left: 20px; top: 247px; position: absolute" Text="Confirm password: "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 19px; top: 272px; position: absolute" width="176px" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" style="z-index: 1; left: 18px; top: 309px; position: absolute" Text="Register account" />
        <asp:Button ID="btnSignIn" runat="server" BorderStyle="None" OnClick="btnSignIn_Click" style="z-index: 1; left: 20px; top: 347px; position: absolute" Text="Sign in" />
        <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 25px; top: 383px; position: absolute"></asp:Label>
        <p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 265px; top: 41px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
    </form>
</body>
</html>
