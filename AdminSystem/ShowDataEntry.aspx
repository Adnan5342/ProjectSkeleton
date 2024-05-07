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
        <asp:Label ID="lblShowId" runat="server" style="z-index: 1; left: 235px; top: 143px; position: absolute; width: 86px;" Text="Show ID: "></asp:Label>
        <asp:Label ID="lblShowIdText" runat="server" style="z-index: 1; left: 316px; top: 141px; position: absolute; " width="172"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 235px; top: 173px; position: absolute" Text="Title:"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 316px; top: 168px; position: absolute; right: 942px;" height="22px" width="135px"></asp:TextBox>
        <asp:Label ID="lblSeasons" runat="server" style="z-index: 1; left: 234px; top: 231px; position: absolute" Text="Seasons:"></asp:Label>
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 504px; top: 141px; position: absolute" Text="Release Date:"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 504px; top: 261px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblGenre" runat="server" style="z-index: 1; left: 235px; top: 202px; position: absolute; right: 910px;" Text="Genre:"></asp:Label>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 239px; top: 261px; position: absolute" Text="Rating: "></asp:Label>
        <asp:Label ID="lblCreators" runat="server" style="z-index: 1; left: 504px; top: 172px; position: absolute" Text="Creators:"></asp:Label>
        <asp:Label ID="lblStarActors" runat="server" style="z-index: 1; left: 504px; position: absolute; top: 202px;" Text="Star Actors" height="19"></asp:Label>
        <asp:Label ID="lblCoverImage" runat="server" style="z-index: 1; left: 504px; top: 236px; position: absolute" Text="Cover Image"></asp:Label>
        <asp:TextBox ID="txtSeasons" runat="server" style="z-index: 1; left: 316px; top: 232px; position: absolute" height="22px" width="135px"></asp:TextBox>
        <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 609px; top: 137px; position: absolute" height="22px" width="135px"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 609px; top: 261px; position: absolute; height: 46px; width: 257px;" TextMode="MultiLine"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtGenre" runat="server" style="z-index: 1; left: 316px; top: 199px; position: absolute; bottom: 449px;" height="22px" width="135px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 316px; top: 262px; position: absolute" height="22px" width="135px"></asp:TextBox>
        <asp:TextBox ID="txtCreators" runat="server" style="z-index: 1; left: 609px; top: 168px; position: absolute" height="22px" width="135px"></asp:TextBox>
        <asp:TextBox ID="txtStarActors" runat="server" style="z-index: 1; left: 609px; position: absolute; top: 198px;" height="22px" width="135px"></asp:TextBox>
        <asp:TextBox ID="txtCoverImage" runat="server" style="z-index: 1; left: 609px; top: 235px; position: absolute; width: 135px;"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 236px; top: 348px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 237px; top: 312px; position: absolute" Text="OK" height="26px" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 322px; top: 312px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 18px; top: 25px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <asp:Label ID="lblShowEntry" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 235px; top: 85px; position: absolute" Text="TV Show Entry Form"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 462px; top: 266px; position: absolute; width: 14px" Text="/5"></asp:Label>
    </form>
</body>
</html>
