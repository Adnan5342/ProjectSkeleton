<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MovieReviewList.aspx.cs" Inherits="MovieReviewList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 400px; top: 125px; position: absolute" Text="Movie Review List"></asp:Label>
        </p>
        <div>
        </div>
            <asp:ListBox ID="lstMovieReviewList" runat="server" style="z-index: 1; left: 400px; top: 170px; position: absolute; height: 407px; width: 531px"></asp:ListBox>
        <p>
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 400px; top: 584px; position: absolute" Text="Delete review" width="136px" />
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" OnClick="imgBtnLogo_Click" />
            <asp:LinkButton ID="lnkBtnShowReviews" runat="server" OnClick="lnkBtnShowReviews_Click" style="z-index: 1; left: 949px; top: 255px; width: 150px; position: absolute">TV Show Review List</asp:LinkButton>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 564px; top: 587px; width: 250px; position: absolute"></asp:Label>
        <asp:LinkButton ID="lnkBtnMovies" runat="server" style="z-index: 1; left: 949px; top: 284px; width: 150px; position: absolute" OnClick="lnkBtnMovies_Click">Movie List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnShows" runat="server" style="z-index: 1; left: 949px; top: 316px; width: 150px; position: absolute" OnClick="lnkBtnShows_Click">TV Show List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnUsers" runat="server" style="z-index: 1; left: 949px; top: 349px; width: 150px; position: absolute" OnClick="lnkBtnUsers_Click">User List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnMessages" runat="server" style="z-index: 1; left: 949px; top: 378px; width: 150px; position: absolute" OnClick="lnkBtnMessages_Click">Message List</asp:LinkButton>
    </form>
</body>
</html>
