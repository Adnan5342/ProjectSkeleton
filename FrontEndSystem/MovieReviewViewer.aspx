<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MovieReviewViewer.aspx.cs" Inherits="MovieReviewViewer" %>

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
        <asp:Label ID="lblMovieId" runat="server" style="z-index: 1; left: 14px; top: 134px; position: absolute" Text="Movie ID"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 10px; top: 184px; position: absolute" Text="Rating"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblMovieIdText" runat="server" style="z-index: 1; left: 99px; top: 133px; position: absolute"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblComment" runat="server" style="z-index: 1; left: 10px; top: 217px; position: absolute" Text="Comment"></asp:Label>
            <asp:Label ID="lblRatingText" runat="server" style="z-index: 1; left: 97px; top: 183px; position: absolute"></asp:Label>
            <asp:Label ID="lblMemberId" runat="server" style="z-index: 1; left: 15px; top: 158px; position: absolute" Text="MemberId"></asp:Label>
            <asp:Label ID="lblMemberIdText" runat="server" style="z-index: 1; left: 101px; top: 159px; position: absolute"></asp:Label>
        </p>
        <p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 14px; top: 21px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <asp:Label ID="lblCommentText" runat="server" style="z-index: 1; left: 94px; top: 220px; width: 300px; height: 100px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 9px; top: 344px; position: absolute" Text="Delete Review" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 393px; position: absolute"></asp:Label>
    </form>
</body>
</html>
