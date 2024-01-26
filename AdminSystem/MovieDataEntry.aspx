<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MovieDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    &nbsp;<p>
            <asp:TextBox ID="txtMovieId" runat="server" style="z-index: 1; left: 107px; top: 20px; position: absolute"></asp:TextBox>
        </p>
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 13px; top: 53px; position: absolute" Text="Title:"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 107px; top: 52px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblRuntime" runat="server" style="z-index: 1; left: 13px; top: 88px; position: absolute" Text="Runtime:"></asp:Label>
        <asp:TextBox ID="txtRuntime" runat="server" style="z-index: 1; left: 107px; top: 87px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblMovieId" runat="server" style="z-index: 1; left: 13px; top: 21px; position: absolute" Text="Movie ID:"></asp:Label>
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 13px; top: 131px; position: absolute" Text="Release Date:"></asp:Label>
        <p>
            <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 107px; top: 130px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCoverImage" runat="server" style="z-index: 1; left: 13px; top: 399px; position: absolute" Text="Cover Image: "></asp:Label>
        </p>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 13px; top: 172px; position: absolute" Text="Description:"></asp:Label>
        <p>
            <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 107px; top: 171px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblGenre" runat="server" style="z-index: 1; left: 13px; top: 208px; position: absolute" Text="Genre:"></asp:Label>
        <asp:TextBox ID="txtGenre" runat="server" style="z-index: 1; left: 107px; top: 207px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 13px; top: 249px; position: absolute; margin-bottom: 0px" Text="Rating:"></asp:Label>
        <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 107px; top: 248px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDirector" runat="server" style="z-index: 1; left: 13px; top: 287px; position: absolute; right: 1086px;" Text="Directors:"></asp:Label>
        <asp:TextBox ID="txtDirectors" runat="server" style="z-index: 1; left: 107px; top: 286px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblWriter" runat="server" style="z-index: 1; left: 13px; top: 322px; position: absolute; width: 51px;" Text="Writers:"></asp:Label>
        <asp:TextBox ID="txtWriters" runat="server" style="z-index: 1; left: 107px; top: 321px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblStarActors" runat="server" style="z-index: 1; left: 13px; top: 361px; position: absolute; bottom: 297px;" Text="Star Actors:"></asp:Label>
        </p>
        <asp:TextBox ID="txtStarActors" runat="server" style="z-index: 1; left: 107px; top: 360px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 13px; top: 482px; position: absolute" Text="OK" width="60px" />
        <p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 110px; top: 482px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 443px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtCoverImage" runat="server" style="z-index: 1; left: 107px; top: 398px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
