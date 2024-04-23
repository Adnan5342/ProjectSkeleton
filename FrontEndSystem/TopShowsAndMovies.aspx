<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TopShowsAndMovies.aspx.cs" Inherits="TopShowsAndMovies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" OnClick="imgBtnLogo_Click" />
        <asp:ImageButton ID="imgBtnProfile" runat="server" ImageUrl="~/Images/ProfileIcon.png" OnClick="imgBtnProfile_Click" style="z-index: 1; left: 929px; top: 58px; position: absolute; height: 50px; " />
        <asp:Label ID="lblTopMovies" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Larger" Font-Underline="True" style="z-index: 1; left: 560px; top: 190px; position: absolute" Text="Top 5 Movies"></asp:Label>
        <p>
            <asp:Label ID="lblTopShows" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Larger" Font-Underline="True" style="z-index: 1; left: 564px; top: 575px; position: absolute" Text="Top 5 Shows"></asp:Label>
        <asp:Image ID="imgMovieImage1" runat="server" style="z-index: 1; left: 62px; top: 235px; width: 200px; height: 300px; position: absolute" />
        </p>
        <asp:Image ID="imgMovieImage2" runat="server" style="z-index: 1; left: 295px; top: 235px; width: 200px; height: 300px; position: absolute" />
        <p>
        <asp:Image ID="imgMovieImage3" runat="server" style="z-index: 1; left: 529px; top: 235px; width: 200px; height: 300px; position: absolute" />
        <asp:Image ID="imgMovieImage4" runat="server" style="z-index: 1; left: 761px; top: 235px; width: 200px; height: 300px; position: absolute" />
        <asp:Image ID="imgMovieImage5" runat="server" style="z-index: 1; left: 995px; top: 235px; width: 200px; height: 300px; position: absolute" />
        <asp:Image ID="imgShowImage1" runat="server" style="z-index: 1; left: 62px; top: 616px; width: 200px; height: 300px; position: absolute" />
        <asp:Image ID="imgShowImage2" runat="server" style="z-index: 1; left: 295px; top: 616px; width: 200px; height: 300px; position: absolute" />
        </p>
        <p>
        <asp:Image ID="imgShowImage3" runat="server" style="z-index: 1; left: 529px; top: 616px; width: 200px; height: 300px; position: absolute" />
        </p>
        <p>
        <asp:Image ID="imsShowImage4" runat="server" style="z-index: 1; left: 761px; top: 616px; width: 200px; height: 300px; position: absolute" />
        </p>
        <p>
        <asp:Image ID="imgShowImage5" runat="server" style="z-index: 1; left: 995px; top: 616px; width: 200px; height: 300px; position: absolute" />
        </p>
    </form>
</body>
</html>
