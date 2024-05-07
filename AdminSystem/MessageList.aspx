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
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" OnClick="imgBtnLogo_Click" />
            </p>
        <p>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 400px; top: 125px; position: absolute" Text="Message List"></asp:Label>
        </p>
            <asp:ListBox ID="lstMessageList" runat="server" style="z-index: 1; left: 400px; top: 163px; position: absolute; height: 407px; width: 531px"></asp:ListBox>
        <p>
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 400px; top: 584px; position: absolute" Text="Delete message" width="136px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 553px; top: 589px; width: 250px; position: absolute"></asp:Label>
        </p>
        <asp:LinkButton ID="lnkBtnMembers" runat="server" style="z-index: 1; left: 949px; top: 255px; width: 150px; position: absolute" OnClick="lnkBtnMembers_Click">User List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnMovies" runat="server" style="z-index: 1; left: 949px; top: 284px; width: 150px; position: absolute" OnClick="lnkBtnMovies_Click">Movie List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnShows" runat="server" style="z-index: 1; left: 949px; top: 315px; width: 150px; position: absolute" OnClick="lnkBtnShows_Click">TV Show List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnMovieReviews" runat="server" style="z-index: 1; left: 949px; top: 346px; width: 150px; position: absolute" OnClick="lnkBtnMovieReviews_Click">Movie Review List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnShowReviews" runat="server" style="z-index: 1; left: 949px; top: 376px; width: 150px; position: absolute" OnClick="lnkBtnShowReviews_Click">TV Show Review List</asp:LinkButton>
    </form>
</body>
</html>
