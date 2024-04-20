﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MovieViewer.aspx.cs" Inherits="MovieViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMovieDetails" runat="server" style="z-index: 1; left: 20px; top: 152px; position: absolute" Text="Movie Details" Font-Bold="True" Font-Overline="True" Font-Size="X-Large" Font-Underline="True"></asp:Label>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 17px; top: 193px; position: absolute" Font-Bold="True" Font-Size="Large"></asp:Label>
        <asp:Image ID="imgCoverImage" runat="server" style="z-index: 1; left: 22px; top: 229px; width: 200px; height: 300px; position: absolute" />
        <p>
            <asp:Label ID="lblRuntimeText" runat="server" style="z-index: 1; left: 368px; top: 358px; position: absolute"></asp:Label>
        </p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" OnClick="imgBtnLogo_Click" />
        <asp:Label ID="lblReleaseDateText" runat="server" style="z-index: 1; left: 364px; top: 249px; position: absolute; height: 19px;"></asp:Label>
        <asp:Label ID="lblDescriptionText" runat="server" style="z-index: 1; left: 268px; top: 422px; position: absolute; right: 81px; height: 56px;"></asp:Label>
        <asp:Label ID="lblGenreText" runat="server" style="z-index: 1; left: 362px; top: 222px; position: absolute"></asp:Label>
        <asp:Label ID="lblRatingText" runat="server" style="z-index: 1; left: 368px; top: 390px; position: absolute"></asp:Label>
        <asp:Label ID="lblDirectorsText" runat="server" style="z-index: 1; left: 366px; top: 276px; position: absolute"></asp:Label>
        <asp:Label ID="lblWritersText" runat="server" style="z-index: 1; left: 367px; top: 333px; position: absolute"></asp:Label>
        <asp:Label ID="lblStarActorsText" runat="server" style="z-index: 1; left: 364px; top: 302px; position: absolute"></asp:Label>
        <p>
        <asp:ImageButton ID="imgBtnProfile" runat="server" ImageUrl="~/Images/ProfileIcon.png" OnClick="imgBtnProfile_Click" style="z-index: 1; left: 1131px; top: 53px; position: absolute; height: 50px; " />
        </p>
        <asp:Label ID="lblGenreLabel" runat="server" style="z-index: 1; left: 265px; top: 223px; position: absolute" Text="Genre(s): "></asp:Label>
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 266px; top: 249px; position: absolute; height: 19px;" Text="Release Date: "></asp:Label>
        <asp:Label ID="lblDirectors" runat="server" style="z-index: 1; left: 266px; top: 276px; position: absolute" Text="Directors: "></asp:Label>
        <asp:Label ID="lblStarActors" runat="server" style="z-index: 1; left: 266px; top: 303px; position: absolute" Text="Star Actors:"></asp:Label>
        <asp:Label ID="lblWriters" runat="server" style="z-index: 1; left: 265px; top: 332px; position: absolute" Text="Writers: "></asp:Label>
        <asp:Label ID="lblRuntime" runat="server" style="z-index: 1; left: 265px; top: 359px; position: absolute" Text="Runtime: "></asp:Label>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 265px; top: 388px; position: absolute" Text="Rating: "></asp:Label>
    </form>
</body>
</html>
