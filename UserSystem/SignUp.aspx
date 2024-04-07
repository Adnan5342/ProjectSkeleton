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
        <asp:Label ID="Label4" runat="server" Font-Size="Large" style="z-index: 1; left: 294px; top: 281px; position: absolute" Text="Password: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 150px; top: 232px; position: absolute; height: 22px; width: 164px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" height="22px" style="z-index: 1; left: 348px; top: 232px; position: absolute" width="164px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" height="22px" style="z-index: 1; left: 245px; top: 312px; position: absolute" width="164px"></asp:TextBox>
    </form>
</body>
</html>
