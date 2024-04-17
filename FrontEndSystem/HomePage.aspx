<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

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
        <asp:Label ID="lblTitle" runat="server" SelectionMode="Single" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 279px; top: 70px; position: absolute" Text="Home Page"></asp:Label>
        <asp:Label ID="lblMovies" runat="server" style="z-index: 1; left: 21px; top: 157px; position: absolute; right: 558px" Text="Movies" Font-Bold="True" Font-Italic="False" Font-Overline="True" Font-Size="Large" Font-Underline="True"></asp:Label>
        <asp:ListBox ID="lstMovieList" runat="server" style="z-index: 1; left: 17px; top: 185px; position: absolute; height: 246px; width: 221px"></asp:ListBox>
        <asp:Label ID="lblShows" runat="server" style="z-index: 1; left: 280px; top: 156px; position: absolute" Text="Shows" Font-Bold="True" Font-Overline="True" Font-Size="Large" Font-Underline="True"></asp:Label>
        <asp:ListBox ID="lstShowList" runat="server" height="246px" style="z-index: 1; left: 277px; top: 185px; position: absolute" width="221px"></asp:ListBox>
        <p>
        <asp:ImageButton ID="imgBtnProfile" runat="server" ImageUrl="~/Images/ProfileIcon.png" OnClick="imgBtnProfile_Click" style="z-index: 1; left: 528px; top: 58px; position: absolute; height: 50px; " />
        </p>
        <asp:Button ID="btnViewMovie" runat="server" style="z-index: 1; left: 17px; top: 472px; position: absolute" Text="View movie" OnClick="btnViewMovie_Click" />
        <asp:Button ID="btnViewShow" runat="server" height="26px" style="z-index: 1; left: 277px; top: 472px; position: absolute" Text="View show" width="99px" OnClick="btnViewShow_Click" />
        <asp:Label ID="lblMovieError" runat="server" style="z-index: 1; left: 19px; top: 521px; position: absolute"></asp:Label>
        <asp:Label ID="lblShowError" runat="server" style="z-index: 1; left: 276px; top: 519px; position: absolute"></asp:Label>
        <asp:Button ID="btnSearchMovies" runat="server" height="26px" OnClick="btnSearchMovies_Click" style="z-index: 1; left: 181px; top: 438px; position: absolute; width: 56px; right: 390px" Text="Search" />
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtSearchMovie" runat="server" style="z-index: 1; left: 17px; top: 441px; position: absolute; width: 150px"></asp:TextBox>
        <asp:TextBox ID="txtSearchShow" runat="server" style="z-index: 1; left: 277px; top: 441px; position: absolute" width="150px"></asp:TextBox>
        <asp:Button ID="btnSearchShows" runat="server" height="26px" OnClick="btnSearchShows_Click" style="z-index: 1; left: 442px; top: 439px; position: absolute" Text="Search" width="56px" />
        <asp:Button ID="btnClearMovies" runat="server" height="26px" OnClick="btnClearMovies_Click" style="z-index: 1; left: 181px; top: 472px; position: absolute" Text="Clear" width="56px" />
        <asp:Button ID="btnClearShows" runat="server" height="26px" OnClick="btnClearShows_Click" style="z-index: 1; left: 442px; top: 472px; position: absolute" Text="Clear" width="56px" />
    </form>
</body>
</html>
