<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblShowId" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Show ID"></asp:Label>
        <p>
            <asp:TextBox ID="txtShowId" runat="server" style="z-index: 1; left: 83px; top: 33px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 10px; top: 67px; position: absolute" Text="Title"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 84px; top: 68px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSeasons" runat="server" style="z-index: 1; left: 9px; top: 98px; position: absolute" Text="Seasons"></asp:Label>
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 14px; top: 127px; position: absolute" Text="Release Date"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 15px; top: 156px; position: absolute; bottom: 491px" Text="Description"></asp:Label>
        <asp:Label ID="lblGenre" runat="server" style="z-index: 1; left: 16px; top: 195px; position: absolute" Text="Genre"></asp:Label>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 19px; top: 234px; position: absolute" Text="Rating"></asp:Label>
        <asp:Label ID="lblCreators" runat="server" style="z-index: 1; left: 20px; top: 273px; position: absolute" Text="Creators"></asp:Label>
        <asp:Label ID="lblStarActors" runat="server" style="z-index: 1; left: 20px; top: 305px; position: absolute" Text="Star Actors"></asp:Label>
        <asp:Label ID="lblCoverImage" runat="server" style="z-index: 1; left: 16px; top: 341px; position: absolute" Text="Cover Image"></asp:Label>
        <asp:TextBox ID="txtSeasons" runat="server" style="z-index: 1; left: 102px; top: 101px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 118px; top: 129px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 111px; top: 155px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtGenre" runat="server" style="z-index: 1; left: 85px; top: 192px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 79px; top: 232px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCreators" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 97px; top: 267px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStarActors" runat="server" style="z-index: 1; left: 104px; top: 303px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCoverImage" runat="server" style="z-index: 1; left: 108px; top: 340px; position: absolute; right: 417px"></asp:TextBox>
    </form>
</body>
</html>
