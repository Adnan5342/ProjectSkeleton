<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MessageList.aspx.cs" Inherits="MessageList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Message Management</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 12px; top: 17px; position: absolute" OnClick="imgBtnLogo_Click" />
            </p>
        <p>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 16px; top: 133px; position: absolute" Text="Message List"></asp:Label>
        </p>
            <asp:ListBox ID="lstMessageList" runat="server" style="z-index: 1; left: 15px; top: 170px; position: absolute; height: 407px; width: 531px"></asp:ListBox>
        <p>
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 16px; top: 594px; position: absolute" Text="Delete message" width="136px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 570px; top: 449px; width: 250px; position: absolute"></asp:Label>
        </p>
        <asp:LinkButton ID="lnkBtnMembers" runat="server" style="z-index: 1; left: 570px; top: 260px; width: 150px; position: absolute" OnClick="lnkBtnMembers_Click">User List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnMovies" runat="server" style="z-index: 1; left: 570px; top: 294px; width: 150px; position: absolute" OnClick="lnkBtnMovies_Click">Movie List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnShows" runat="server" style="z-index: 1; left: 570px; top: 327px; width: 150px; position: absolute" OnClick="lnkBtnShows_Click">TV Show List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnMovieReviews" runat="server" style="z-index: 1; left: 570px; top: 361px; width: 150px; position: absolute" OnClick="lnkBtnMovieReviews_Click">Movie Review List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnShowReviews" runat="server" style="z-index: 1; left: 570px; top: 393px; width: 150px; position: absolute" OnClick="lnkBtnShowReviews_Click">TV Show Review List</asp:LinkButton>
    </form>
</body>
</html>
