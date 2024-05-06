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
        <asp:Label ID="lblWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 469px; top: 134px; width: 450px; position: absolute" Text="Welcome to the Admin System. "></asp:Label>
        <asp:Button ID="btnMovies" runat="server" style="z-index: 1; left: 425px; top: 199px; position: absolute; right: 844px;" Text="Manage Movies" height="26px" OnClick="btnMovies_Click" width="151px" />
        <asp:Button ID="btnShows" runat="server" style="z-index: 1; left: 592px; top: 199px; position: absolute" Text="Manage Shows" width="151px" height="26px" OnClick="btnShows_Click" />
        <asp:Button ID="btnMembers" runat="server" height="26px" OnClick="btnMembers_Click" style="z-index: 1; left: 759px; top: 199px; position: absolute" Text="Manage Users" width="151px" />
        <asp:Button ID="btnMovieReviews" runat="server" height="26px" style="z-index: 1; left: 425px; top: 286px; position: absolute; width: 151px; " Text="Manage Movie Reviews" OnClick="btnMovieReviews_Click" />
        <asp:Button ID="btnShowReviews" runat="server" height="26px" style="z-index: 1; left: 592px; top: 286px; position: absolute" Text="Manage Show Reviews" width="151px" OnClick="btnShowReviews_Click" />
        <asp:Button ID="btnMessages" runat="server" height="26px" OnClick="btnMessages_Click" style="z-index: 1; left: 759px; top: 286px; position: absolute" Text="Manage Messages" width="151px" />
        <asp:LinkButton ID="lnkBtnSignOut" runat="server" OnClick="lnkBtnSignOut_Click" style="z-index: 1; left: 643px; top: 419px; width: 55px; position: absolute">Sign out</asp:LinkButton>
        <asp:Label ID="lblMovieCount" runat="server" style="z-index: 1; left: 425px; top: 236px; width: 150px; position: absolute" Text="Movie Count: "></asp:Label>
        <asp:Label ID="lblShowCount" runat="server" style="z-index: 1; left: 592px; top: 236px; width: 150px; position: absolute" Text="TV Show Count: "></asp:Label>
        <asp:Label ID="lblUserCount" runat="server" style="z-index: 1; left: 761px; top: 236px; width: 150px; position: absolute" Text="User Count: "></asp:Label>
        <asp:Label ID="lblMessageCount" runat="server" style="z-index: 1; left: 761px; top: 324px; width: 150px; position: absolute" Text="Message Count: "></asp:Label>
        <asp:Label ID="lblMReviewCount" runat="server" style="z-index: 1; left: 425px; top: 324px; width: 150px; position: absolute" Text="Review Count: "></asp:Label>
        <asp:Label ID="lblSReviewCount" runat="server" style="z-index: 1; left: 592px; top: 324px; width: 150px; position: absolute" Text="Review Count: "></asp:Label>
    </form>
</body>
</html>
