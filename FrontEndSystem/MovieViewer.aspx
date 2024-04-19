<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MovieViewer.aspx.cs" Inherits="MovieViewer" %>

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
        <asp:Image ID="imgCoverImage" runat="server" style="z-index: 1; left: 22px; top: 262px; position: absolute" />
        <p>
            <asp:Label ID="lblRuntime" runat="server" style="z-index: 1; left: 300px; top: 101px; position: absolute"></asp:Label>
        </p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" OnClick="imgBtnLogo_Click" />
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 299px; top: 147px; position: absolute"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 302px; top: 184px; position: absolute"></asp:Label>
        <asp:Label ID="lblGenre" runat="server" style="z-index: 1; left: 302px; top: 226px; position: absolute"></asp:Label>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 302px; top: 257px; position: absolute"></asp:Label>
        <asp:Label ID="lblDirectors" runat="server" style="z-index: 1; left: 302px; top: 291px; position: absolute"></asp:Label>
        <asp:Label ID="lblWriters" runat="server" style="z-index: 1; left: 302px; top: 322px; position: absolute"></asp:Label>
        <asp:Label ID="lblStarActors" runat="server" style="z-index: 1; left: 305px; top: 358px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtMovieId" runat="server" style="z-index: 1; left: 432px; top: 92px; position: absolute; width: 44px"></asp:TextBox>
    </form>
</body>
</html>
