<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MovieList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstMovieList" runat="server" style="z-index: 1; left: 10px; top: 64px; position: absolute; height: 407px; width: 531px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 504px; position: absolute" Text="Add new record" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 183px; top: 504px; position: absolute" Text="Edit record" width="136px" height="26px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 558px; position: absolute"></asp:Label>
        <asp:Label ID="lblFilterByTitle" runat="server" style="z-index: 1; left: 570px; top: 64px; position: absolute" Text="Filter by title: "></asp:Label>
        <p>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Movie List"></asp:Label>
        </p>
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 355px; top: 504px; position: absolute" Text="Delete record" width="136px" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 570px; top: 122px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" height="26px" OnClick="btnClear_Click" style="z-index: 1; left: 643px; top: 122px; position: absolute; width: 49px;" Text="Clear" />
        <asp:TextBox ID="txtFilterByTitle" runat="server" style="z-index: 1; left: 570px; top: 91px; position: absolute"></asp:TextBox>
        <p>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 570px; top: 154px; position: absolute" />
        </p>
        <p>
            <asp:LinkButton ID="lnkBtnShows" runat="server" OnClick="lnkBtnMovies_Click" style="z-index: 1; left: 567px; top: 273px; position: absolute">Go to &#39;shows&#39; list</asp:LinkButton>
        </p>
    </form>
</body>
</html>
