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
        <asp:Label ID="lblSignUpForm" runat="server" Font-Bold="True" style="z-index: 1; left: 276px; top: 138px; position: absolute" Text="Sign Up Form" Font-Size="Larger"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 14px; top: 67px; position: absolute" Text="Username: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 14px; top: 90px; position: absolute; width: 176px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 276px; top: 178px; position: absolute" Text="Email: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 276px; top: 203px; position: absolute" width="176px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 276px; top: 235px; position: absolute" Text="Password: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 276px; top: 258px; position: absolute" width="176px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblConfirmPassword" runat="server" style="z-index: 1; left: 276px; top: 289px; position: absolute" Text="Confirm password: "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 276px; top: 313px; position: absolute" width="176px" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" style="z-index: 1; left: 276px; top: 348px; position: absolute" Text="Register account" />
        <asp:Button ID="btnSignIn" runat="server" BorderStyle="None" OnClick="btnSignIn_Click" style="z-index: 1; left: 276px; top: 384px; position: absolute; width: 174px;" Text="Already registered? Sign in." />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 276px; top: 418px; position: absolute" Font-Bold="True"></asp:Label>
        <p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
    </form>
</body>
</html>
