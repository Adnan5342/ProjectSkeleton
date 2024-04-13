<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

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
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 378px; top: 68px; position: absolute" Text="Home Page"></asp:Label>
    </form>
</body>
</html>
