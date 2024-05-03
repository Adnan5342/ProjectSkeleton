<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminHome.aspx.cs" Inherits="AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Home</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 17px; top: 18px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <asp:Label ID="lblWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 18px; top: 125px; position: absolute" Text="Welcome to the Admin System. "></asp:Label>
        <asp:Button ID="btnMovies" runat="server" style="z-index: 1; left: 88px; top: 210px; position: absolute; right: 973px;" Text="Manage Movies" height="26px" OnClick="btnMovies_Click" width="151px" />
        <asp:Button ID="btnShows" runat="server" style="z-index: 1; left: 251px; top: 209px; position: absolute" Text="Manage Shows" width="151px" height="26px" OnClick="btnShows_Click" />
        <asp:Button ID="btnMembers" runat="server" height="26px" OnClick="btnMembers_Click" style="z-index: 1; left: 166px; top: 290px; position: absolute" Text="Manage Users" width="151px" />
        <asp:Button ID="btnMovieReviews" runat="server" height="26px" style="z-index: 1; left: 91px; top: 248px; position: absolute; width: 151px" Text="Manage Movie Reviews" OnClick="btnMovieReviews_Click" />
        <asp:Button ID="btnShowReviews" runat="server" height="26px" style="z-index: 1; left: 252px; top: 249px; position: absolute" Text="Manage Show Reviews" width="151px" OnClick="btnShowReviews_Click" />
    </form>
</body>
</html>
