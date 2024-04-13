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
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 279px; top: 70px; position: absolute" Text="Home Page"></asp:Label>
        <asp:Label ID="lblMovies" runat="server" style="z-index: 1; left: 21px; top: 157px; position: absolute; right: 647px" Text="Movies"></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 17px; top: 186px; position: absolute; height: 134px; width: 221px"></asp:ListBox>
        <asp:Label ID="lblShows" runat="server" style="z-index: 1; left: 280px; top: 156px; position: absolute" Text="Shows"></asp:Label>
        <asp:ListBox ID="ListBox2" runat="server" height="134px" style="z-index: 1; left: 277px; top: 186px; position: absolute" width="221px"></asp:ListBox>
    </form>
</body>
</html>
