<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TV Show Entry</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblShowId" runat="server" style="z-index: 1; left: 9px; top: 34px; position: absolute" Text="Show ID"></asp:Label>
        <p>
            <asp:TextBox ID="txtShowId" runat="server" style="z-index: 1; left: 118px; top: 33px; position: absolute" height="22px" width="136px"></asp:TextBox>
        </p>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 9px; top: 67px; position: absolute" Text="Title"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 118px; top: 61px; position: absolute" height="22px" width="136px"></asp:TextBox>
        <asp:Label ID="lblSeasons" runat="server" style="z-index: 1; left: 9px; top: 98px; position: absolute" Text="Seasons"></asp:Label>
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 9px; top: 128px; position: absolute" Text="Release Date"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 9px; top: 156px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblGenre" runat="server" style="z-index: 1; left: 9px; top: 188px; position: absolute" Text="Genre"></asp:Label>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 9px; top: 219px; position: absolute" Text="Rating"></asp:Label>
        <asp:Label ID="lblCreators" runat="server" style="z-index: 1; left: 9px; top: 253px; position: absolute" Text="Creators"></asp:Label>
        <asp:Label ID="lblStarActors" runat="server" style="z-index: 1; left: 9px; top: 286px; position: absolute" Text="Star Actors"></asp:Label>
        <asp:Label ID="lblCoverImage" runat="server" style="z-index: 1; left: 9px; top: 319px; position: absolute" Text="Cover Image"></asp:Label>
        <asp:TextBox ID="txtSeasons" runat="server" style="z-index: 1; left: 118px; top: 94px; position: absolute" height="22px" width="136px"></asp:TextBox>
        <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 118px; top: 123px; position: absolute" height="22px" width="136px"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 118px; top: 152px; position: absolute" height="22px" width="136px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtGenre" runat="server" style="z-index: 1; left: 118px; top: 184px; position: absolute" height="22px" width="136px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 118px; top: 219px; position: absolute" height="22px" width="136px"></asp:TextBox>
        <asp:TextBox ID="txtCreators" runat="server" style="z-index: 1; left: 118px; top: 254px; position: absolute" height="22px" width="136px"></asp:TextBox>
        <asp:TextBox ID="txtStarActors" runat="server" style="z-index: 1; left: 118px; top: 283px; position: absolute" height="22px" width="136px"></asp:TextBox>
        <asp:TextBox ID="txtCoverImage" runat="server" style="z-index: 1; left: 118px; top: 316px; position: absolute; width: 135px;"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 373px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 16px; top: 403px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 71px; top: 402px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 287px; top: 30px; position: absolute" Text="Find" />
        <p>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 285px; top: 67px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
    </form>
</body>
</html>
