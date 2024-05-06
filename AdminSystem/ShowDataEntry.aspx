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
        <asp:Label ID="lblShowId" runat="server" style="z-index: 1; left: 21px; top: 183px; position: absolute; width: 86px;" Text="Show ID: "></asp:Label>
        <asp:Label ID="lblShowIdText" runat="server" style="z-index: 1; left: 108px; top: 182px; position: absolute; right: 531px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 21px; top: 216px; position: absolute" Text="Title:"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 108px; top: 211px; position: absolute; right: 487px;" height="22px" width="135px"></asp:TextBox>
        <asp:Label ID="lblSeasons" runat="server" style="z-index: 1; left: 21px; top: 278px; position: absolute" Text="Seasons:"></asp:Label>
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 284px; top: 182px; position: absolute" Text="Release Date:"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 283px; top: 307px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblGenre" runat="server" style="z-index: 1; left: 21px; top: 247px; position: absolute" Text="Genre:"></asp:Label>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 21px; top: 307px; position: absolute" Text="Rating: "></asp:Label>
        <asp:Label ID="lblCreators" runat="server" style="z-index: 1; left: 283px; top: 215px; position: absolute" Text="Creators:"></asp:Label>
        <asp:Label ID="lblStarActors" runat="server" style="z-index: 1; left: 283px; top: 243px; position: absolute" Text="Star Actors"></asp:Label>
        <asp:Label ID="lblCoverImage" runat="server" style="z-index: 1; left: 283px; top: 275px; position: absolute" Text="Cover Image"></asp:Label>
        <asp:TextBox ID="txtSeasons" runat="server" style="z-index: 1; left: 108px; top: 271px; position: absolute" height="22px" width="135px"></asp:TextBox>
        <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 376px; top: 178px; position: absolute" height="22px" width="135px"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 376px; top: 303px; position: absolute" height="100px" width="300px" TextMode="MultiLine"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtGenre" runat="server" style="z-index: 1; left: 108px; top: 239px; position: absolute" height="22px" width="135px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 108px; top: 303px; position: absolute" height="22px" width="135px"></asp:TextBox>
        <asp:TextBox ID="txtCreators" runat="server" style="z-index: 1; left: 376px; top: 211px; position: absolute" height="22px" width="135px"></asp:TextBox>
        <asp:TextBox ID="txtStarActors" runat="server" style="z-index: 1; left: 376px; top: 239px; position: absolute" height="22px" width="135px"></asp:TextBox>
        <asp:TextBox ID="txtCoverImage" runat="server" style="z-index: 1; left: 376px; top: 274px; position: absolute; width: 135px;"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 416px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 21px; top: 360px; position: absolute" Text="OK" height="26px" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 108px; top: 360px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 18px; top: 25px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <asp:Label ID="lblShowEntry" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 21px; top: 140px; position: absolute" Text="TV Show Entry Form"></asp:Label>
    </form>
</body>
</html>
