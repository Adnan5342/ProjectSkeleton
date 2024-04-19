<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowViewer.aspx.cs" Inherits="ShowViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" OnClick="imgBtnLogo_Click" />
        </div>
        <p>
            &nbsp;</p>
        <p>
        <asp:ImageButton ID="imgBtnProfile" runat="server" ImageUrl="~/Images/ProfileIcon.png" OnClick="imgBtnProfile_Click" style="z-index: 1; left: 528px; top: 58px; position: absolute; height: 50px; " />
        <asp:Label ID="lblShowDetails" runat="server" style="z-index: 1; left: 20px; top: 152px; position: absolute" Text="Show Details" Font-Bold="True" Font-Overline="True" Font-Size="X-Large" Font-Underline="True"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblTitleText" runat="server" style="z-index: 1; left: 17px; top: 193px; position: absolute" Font-Bold="True" Font-Size="Large"></asp:Label>
        </p>
        <p>
        <asp:Image ID="imgCoverImage" runat="server" style="z-index: 1; left: 22px; top: 229px; width: 200px; height: 300px; position: absolute" />
        <asp:Label ID="lblGenreText" runat="server" style="z-index: 1; left: 345px; top: 223px; position: absolute"></asp:Label>
        <asp:Label ID="lblGenreLabel" runat="server" style="z-index: 1; left: 265px; top: 223px; position: absolute" Text="Genre(s): "></asp:Label>
        <asp:Label ID="lblDescriptionText" runat="server" style="z-index: 1; left: 264px; top: 255px; position: absolute; right: 996px;"></asp:Label>
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 261px; top: 321px; position: absolute" Text="Release Date: "></asp:Label>
        <asp:Label ID="lblReleaseDateText" runat="server" style="z-index: 1; left: 353px; top: 321px; position: absolute; height: 19px;"></asp:Label>
        <asp:Label ID="lblCreators" runat="server" style="z-index: 1; left: 260px; top: 346px; position: absolute" Text="Creator(s):"></asp:Label>
        <asp:Label ID="lblStarActors" runat="server" style="z-index: 1; left: 259px; top: 375px; position: absolute" Text="Star Actors:"></asp:Label>
        <asp:Label ID="lblCreatorsText" runat="server" style="z-index: 1; left: 353px; top: 347px; position: absolute"></asp:Label>
        <asp:Label ID="lblStarActorsText" runat="server" style="z-index: 1; left: 355px; top: 372px; position: absolute"></asp:Label>
        <asp:Label ID="lblSeasons" runat="server" style="z-index: 1; left: 259px; top: 401px; position: absolute" Text="Seasons: "></asp:Label>
        <asp:Label ID="lblSeasonsText" runat="server" style="z-index: 1; left: 355px; top: 396px; position: absolute"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 258px; top: 453px; position: absolute" Text="Rating: "></asp:Label>
        <asp:Label ID="lblRatingText" runat="server" style="z-index: 1; left: 353px; top: 452px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
