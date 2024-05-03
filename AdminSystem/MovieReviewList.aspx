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
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Movie Review List"></asp:Label>
        </p>
        <div>
        </div>
            <asp:ListBox ID="lstMovieReviewList" runat="server" style="z-index: 1; left: 10px; top: 64px; position: absolute; height: 407px; width: 531px"></asp:ListBox>
        <p>
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 10px; top: 486px; position: absolute" Text="Delete review" width="136px" />
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 570px; top: 154px; position: absolute" OnClick="imgBtnLogo_Click" />
            <asp:LinkButton ID="lnkBtnShowReviews" runat="server" OnClick="lnkBtnMovies_Click" style="z-index: 1; left: 567px; top: 273px; position: absolute">Reviews for shows</asp:LinkButton>
        </p>
    </form>
</body>
</html>
