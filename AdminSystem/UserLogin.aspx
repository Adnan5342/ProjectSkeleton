<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="Front_end_Login" %>

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
            &nbsp;</p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" OnClick="imgbtnLogo_Click" style="z-index: 1; left: 501px; top: 163px; position: absolute; height: 75px; width: 161px" />
        <asp:Label ID="lblUsername" runat="server" Font-Size="X-Large" style="z-index: 1; left: 369px; top: 256px; position: absolute" Text="Username: "></asp:Label>
        <asp:Label ID="lblPassword" runat="server" Font-Size="X-Large" style="z-index: 1; left: 373px; top: 308px; position: absolute; right: 666px" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" height="27px" style="z-index: 1; left: 492px; top: 305px; position: absolute; width: 250px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtUsername" runat="server" height="27px" style="z-index: 1; left: 491px; top: 253px; position: absolute; width: 250px"></asp:TextBox>
        </p>
        <asp:Button ID="lblSignIn" runat="server" Font-Size="Large" style="z-index: 1; left: 667px; top: 355px; position: absolute" Text="Sign in" />
        <p>
            <asp:Button ID="btnSignUp" runat="server" style="z-index: 1; left: 402px; top: 357px; position: absolute" Text="No account? Sign up now!" />
        </p>
        <asp:HyperLink ID="resetPassword" runat="server" ForeColor="#0099FF" style="z-index: 1; left: 464px; top: 397px; position: absolute">Reset password</asp:HyperLink>
    </form>
</body>
</html>
