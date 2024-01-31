<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserViewJurassicPark.aspx.cs" Inherits="UserViewJurassicPark" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Image ID="imgJurassicPark" runat="server" Height="250px" ImageUrl="~/MovieCoverImages/JurassicParkMoviePoster.jpg" style="z-index: 1; left: 33px; top: 152px; position: absolute" />
        <p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" OnClick="imgbtnLogo_Click" style="z-index: 1; left: 7px; top: 12px; position: absolute; height: 75px; width: 161px" />
        <asp:ImageButton ID="imgBtnProfile" runat="server" Height="50px" ImageUrl="~/Images/ProfileIcon.png" OnClick="imgBtnProfile_Click" style="z-index: 1; left: 1030px; top: 25px; position: absolute; bottom: 602px" />
        </p>
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 216px; top: 163px; position: absolute" Text="Jurassic Park"></asp:Label>
        <p>
            <asp:Label ID="lblGenre" runat="server" BorderStyle="Dotted" Font-Bold="False" Font-Size="Medium" style="z-index: 1; left: 347px; top: 159px; position: absolute" Text="Action, Adventure, Sci-fi"></asp:Label>
        </p>
        <asp:Label ID="lblDescription" runat="server" Font-Bold="False" Font-Size="Medium" style="z-index: 1; left: 214px; top: 194px; position: absolute; width: 336px" Text="A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose." BorderStyle="Solid"></asp:Label>
        <asp:Label ID="lblReleaseDate" runat="server" Font-Bold="True" style="z-index: 1; left: 214px; top: 290px; position: absolute" Text="Released: "></asp:Label>
        <asp:Label ID="lblDirectors" runat="server" Font-Bold="True" style="z-index: 1; left: 373px; top: 290px; position: absolute" Text="Directors:"></asp:Label>
        <asp:Label ID="lblWriters" runat="server" Font-Bold="True" style="z-index: 1; left: 373px; top: 315px; position: absolute" Text="Writers: "></asp:Label>
        <asp:Label ID="lblRuntime" runat="server" Font-Bold="True" style="z-index: 1; left: 214px; top: 315px; position: absolute" Text="Runtime: "></asp:Label>
        <asp:Label ID="lblStarActors" runat="server" Font-Bold="True" style="z-index: 1; left: 362px; top: 343px; position: absolute" Text="Star Actors:"></asp:Label>
        <asp:Label ID="lblRating" runat="server" Font-Bold="True" style="z-index: 1; left: 214px; top: 343px; position: absolute" Text="Rating: "></asp:Label>
        <asp:TextBox ID="txtReleaseDate" runat="server" BorderStyle="None" height="18" style="z-index: 1; left: 286px; top: 290px; position: absolute; width: 75px">15/07/1993</asp:TextBox>
        <asp:TextBox ID="txtRuntime" runat="server" BorderStyle="None" style="z-index: 1; left: 291px; top: 315px; position: absolute; width: 64px">2hr, 7min</asp:TextBox>
        <asp:TextBox ID="txtRating" runat="server" BorderStyle="None" style="z-index: 1; left: 291px; top: 343px; position: absolute; width: 33px">4.1</asp:TextBox>
        <asp:TextBox ID="txtDirectors" runat="server" BorderStyle="None" style="z-index: 1; left: 446px; top: 290px; position: absolute">Steven Speilberg</asp:TextBox>
        <asp:TextBox ID="txtWriters" runat="server" BorderStyle="None" style="z-index: 1; left: 446px; top: 317px; position: absolute; width: 180px">Michael Crichton, David Koepp</asp:TextBox>
        <asp:TextBox ID="txtStarActors" runat="server" BorderStyle="None" OnTextChanged="txtStarActors_TextChanged" style="z-index: 1; left: 446px; top: 344px; position: absolute; width: 219px">Sam Niell, Laura Dern, Jeff Goldblum</asp:TextBox>
    </form>
</body>
</html>
