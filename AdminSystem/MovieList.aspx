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
            <asp:ListBox ID="lstMovieList" runat="server" style="z-index: 1; left: 400px; top: 163px; position: absolute; height: 407px; width: 531px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 400px; top: 584px; position: absolute; right: 865px;" Text="Add new movie" height="26px" width="136px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 552px; top: 584px; position: absolute" Text="Edit movie" width="136px" height="26px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 865px; top: 585px; width: 250px; position: absolute" ></asp:Label>
        <asp:Label ID="lblFilterByTitle" runat="server" style="z-index: 1; left: 949px; top: 492px; width: 250px; position: absolute" Text="Filter by title: "></asp:Label>
        <p>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 400px; top: 125px; position: absolute" Text="Movie List"></asp:Label>
        </p>
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 704px; top: 584px; position: absolute" Text="Delete movie" width="136px" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 949px; top: 544px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" height="26px" OnClick="btnClear_Click" style="z-index: 1; left: 1017px; top: 544px; position: absolute; width: 49px;" Text="Clear" />
        <asp:TextBox ID="txtFilterByTitle" runat="server" style="z-index: 1; left: 949px; top: 515px; position: absolute"></asp:TextBox>
        <p>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <p>
            <asp:LinkButton ID="lnkBtnShows" runat="server" OnClick="lnkBtnShows_Click" style="z-index: 1; left: 949px; top: 255px; width: 150px; position: absolute; bottom: 402px;">TV Show List</asp:LinkButton>
        </p>
        <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" style="z-index: 1; left: 949px; top: 167px; position: absolute" Text="View movie" />
        <asp:LinkButton ID="lnkBtnMovieReviews" runat="server" OnClick="lnkBtnMovieReviews_Click" style="z-index: 1; left: 949px; top: 284px; width: 150px; position: absolute">Movie Review List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnShowReviews" runat="server" style="z-index: 1; left: 949px; top: 314px; width: 150px; position: absolute" OnClick="lnkBtnShowReviews_Click">TV Show Review List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnMessages" runat="server" style="z-index: 1; left: 949px; top: 370px; width: 150px; position: absolute" OnClick="lnkBtnMessages_Click">Message List</asp:LinkButton>
        <asp:LinkButton ID="lnkBtnUsers" runat="server" style="z-index: 1; left: 949px; top: 343px; width: 150px; position: absolute" OnClick="lnkBtnUsers_Click">User List</asp:LinkButton>
    </form>
</body>
</html>
