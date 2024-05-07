<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowReviewList.aspx.cs" Inherits="ShowReviewList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 400px; top: 125px; position: absolute" Text="TV Show Review List"></asp:Label>
        </p>
        <p>
            <asp:LinkButton ID="lnkBtnMovieReviews" runat="server" OnClick="lnkBtnMovieReviews_Click" style="z-index: 1; left: 949px; top: 255px; width: 150px; position: absolute">Movie Review List</asp:LinkButton>
        </p>
            <asp:ListBox ID="lstShowReviewList" runat="server" style="z-index: 1; left: 400px; top: 170px; position: absolute; height: 407px; width: 531px"></asp:ListBox>
        <p>
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 400px; top: 584px; position: absolute" Text="Delete review" width="136px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 558px; top: 587px; width: 250px; position: absolute"></asp:Label>
        </p>
        <asp:LinkButton ID="lnkBtnShows" runat="server" style="z-index: 1; left: 949px; top: 284px; width: 150px; position: absolute; bottom: 372px;" OnClick="lnkBtnShows_Click">TV Show List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnMovies" runat="server" style="z-index: 1; left: 949px; top: 313px; width: 150px; position: absolute" OnClick="lnkBtnMovies_Click">Movie List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnUsers" runat="server" style="z-index: 1; left: 949px; top: 343px; width: 150px; position: absolute" OnClick="lnkBtnUsers_Click">User List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnMessages" runat="server" style="z-index: 1; left: 949px; top: 372px; width: 150px; position: absolute" OnClick="lnkBtnMessages_Click">Message List</asp:LinkButton>
    </form>
</body>
</html>
