<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MovieList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movie List</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstMovieList" runat="server" style="z-index: 1; left: 15px; top: 170px; position: absolute; height: 407px; width: 531px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 16px; top: 594px; position: absolute" Text="Add new movie" height="26px" width="136px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 183px; top: 594px; position: absolute" Text="Edit movie" width="136px" height="26px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 570px; top: 449px; width: 250px; position: absolute" ></asp:Label>
        <asp:Label ID="lblFilterByTitle" runat="server" style="z-index: 1; left: 570px; top: 64px; width: 250px; position: absolute" Text="Filter by title: "></asp:Label>
        <p>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 16px; top: 133px; position: absolute" Text="Movie List"></asp:Label>
        </p>
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 355px; top: 594px; position: absolute" Text="Delete movie" width="136px" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 570px; top: 122px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" height="26px" OnClick="btnClear_Click" style="z-index: 1; left: 643px; top: 122px; position: absolute; width: 49px;" Text="Clear" />
        <asp:TextBox ID="txtFilterByTitle" runat="server" style="z-index: 1; left: 570px; top: 91px; position: absolute"></asp:TextBox>
        <p>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 12px; top: 17px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <p>
            <asp:LinkButton ID="lnkBtnShows" runat="server" OnClick="lnkBtnShows_Click" style="z-index: 1; left: 570px; top: 260px; width: 150px; position: absolute">TV Show List</asp:LinkButton>
        </p>
        <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" style="z-index: 1; left: 570px; top: 175px; position: absolute" Text="View movie" />
        <asp:LinkButton ID="lnkBtnMovieReviews" runat="server" OnClick="lnkBtnMovieReviews_Click" style="z-index: 1; left: 570px; top: 294px; width: 150px; position: absolute">Movie Review List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnShowReviews" runat="server" style="z-index: 1; left: 570px; top: 327px; width: 150px; position: absolute" OnClick="lnkBtnShowReviews_Click">TV Show Review List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnMessages" runat="server" style="z-index: 1; left: 570px; top: 393px; width: 150px; position: absolute" OnClick="lnkBtnMessages_Click">Message List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnUsers" runat="server" style="z-index: 1; left: 570px; top: 361px; width: 150px; position: absolute" OnClick="lnkBtnUsers_Click">User List</asp:LinkButton>
    </form>
</body>
</html>
