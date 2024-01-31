<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserHomepage.aspx.cs" Inherits="Front_end_Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="lstMovieList" runat="server">
        <div>
        </div>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" OnClick="imgbtnLogo_Click" style="z-index: 1; left: 7px; top: 12px; position: absolute; height: 75px; width: 161px" />
        <asp:ImageButton ID="imgBtnProfile" runat="server" Height="50px" ImageUrl="~/Images/ProfileIcon.png" OnClick="imgBtnProfile_Click" style="z-index: 1; left: 1030px; top: 25px; position: absolute; bottom: 602px" />
        <asp:ImageButton ID="imgBtnJurassicPark" runat="server" Height="250px" ImageUrl="~/MovieCoverImages/JurassicParkMoviePoster.jpg" style="z-index: 1; left: 7px; top: 162px; position: absolute" OnClick="imgBtnJurassicPark_Click" />
        <asp:ImageButton ID="imgBtnUncharted" runat="server" Height="250px" ImageUrl="~/MovieCoverImages/UnchartedMoviePoster.jpg" style="z-index: 1; left: 235px; top: 162px; position: absolute" />
        <asp:Label ID="lblMovies" runat="server" Font-Bold="True" style="z-index: 1; left: 7px; top: 126px; position: absolute" Text="MOVIES:"></asp:Label>
    </form>
</body>
</html>
