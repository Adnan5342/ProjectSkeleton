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
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 12px; top: 17px; position: absolute" OnClick="imgBtnLogo_Click" />
            </p>
        <p>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 16px; top: 133px; position: absolute" Text="TV Show Review List"></asp:Label>
        </p>
        <p>
            <asp:LinkButton ID="lnkBtnMovieReviews" runat="server" OnClick="lnkBtnMovies_Click" style="z-index: 1; left: 251px; top: 139px; position: absolute">Reviews for movies</asp:LinkButton>
        </p>
            <asp:ListBox ID="lstShowReviewList" runat="server" style="z-index: 1; left: 15px; top: 170px; position: absolute; height: 407px; width: 531px"></asp:ListBox>
        <p>
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 16px; top: 594px; position: absolute" Text="Delete review" width="136px" />
            </p>
    </form>
</body>
</html>
