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
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 276px; top: 142px; position: absolute" Text="Sign Up"></asp:Label>
        <asp:Label ID="Label2" runat="server" Font-Size="Large" style="z-index: 1; left: 197px; top: 201px; position: absolute" Text="Username:"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Size="Large" style="z-index: 1; left: 411px; top: 203px; position: absolute; bottom: 453px" Text="Email: "></asp:Label>
        <asp:Label ID="Label4" runat="server" Font-Size="Large" style="z-index: 1; left: 198px; top: 281px; position: absolute" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 150px; top: 232px; position: absolute; height: 22px; width: 164px"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" height="22px" style="z-index: 1; left: 348px; top: 232px; position: absolute" width="164px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" height="22px" style="z-index: 1; left: 150px; top: 312px; position: absolute" width="164px"></asp:TextBox>
        <asp:Label ID="lblConfirmPass" runat="server" Font-Size="Large" style="z-index: 1; left: 364px; top: 281px; position: absolute" Text="Confirm Password: "></asp:Label>
        <asp:TextBox ID="txtConfirmPass" runat="server" height="22px" style="z-index: 1; left: 348px; top: 312px; position: absolute" width="164px"></asp:TextBox>
        <asp:CheckBox ID="chkRemberMe" runat="server" style="z-index: 1; left: 275px; top: 361px; position: absolute" Text="Remember me" />
        <asp:Button ID="btnRegister" runat="server" Font-Size="Large" style="z-index: 1; left: 225px; top: 399px; position: absolute; width: 217px" Text="Complete Registration" />
        <asp:Button ID="btnSignIn" runat="server" BackColor="White" BorderStyle="None" Font-Underline="True" ForeColor="Blue" style="z-index: 1; left: 307px; top: 445px; position: absolute" Text="Sign in" />
    </form>
</body>
</html>
