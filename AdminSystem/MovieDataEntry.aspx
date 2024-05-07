<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MovieDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movie Entry</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
    &nbsp;<asp:Label ID="lblMovieIdText" runat="server" style="z-index: 1; left: 338px; top: 143px; position: absolute"></asp:Label>
        <p>
        <asp:Label ID="lblMovieEntry" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 235px; top: 85px; position: absolute" Text="Movie Entry Form"></asp:Label>
        </p>
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 235px; top: 173px; position: absolute" Text="Title:"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 338px; top: 172px; position: absolute; width: 120px;"></asp:TextBox>
        <asp:Label ID="lblRuntime" runat="server" style="z-index: 1; left: 235px; top: 201px; position: absolute" Text="Runtime:"></asp:Label>
        <asp:TextBox ID="txtRuntime" runat="server" style="z-index: 1; left: 338px; top: 200px; position: absolute;" width="120px"></asp:TextBox>
        <asp:Label ID="lblMovieId" runat="server" style="z-index: 1; left: 235px; top: 143px; position: absolute; right: 1116px;" Text="Movie ID:"></asp:Label>
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 235px; top: 230px; position: absolute" Text="Release Date:"></asp:Label>
        <p>
            <asp:Label ID="lblCoverImage" runat="server" style="z-index: 1; left: 495px; top: 230px; position: absolute" Text="Cover Image: "></asp:Label>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <p>
            <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 595px; top: 262px; position: absolute; height: 46px; width: 257px;" TextMode="MultiLine"></asp:TextBox>
        </p>
        <asp:Label ID="lblGenre" runat="server" style="z-index: 1; left: 235px; top: 262px; position: absolute; right: 1126px;" Text="Genre:"></asp:Label>
        <asp:TextBox ID="txtGenre" runat="server" style="z-index: 1; left: 338px; top: 262px; position: absolute" width="120px"></asp:TextBox>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 235px; top: 292px; position: absolute; margin-bottom: 0px" Text="Rating:"></asp:Label>
        <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 338px; top: 291px; position: absolute" width="120px"></asp:TextBox>
        <asp:Label ID="lblDirector" runat="server" style="z-index: 1; left: 495px; top: 143px; position: absolute; right: 807px;" Text="Directors:"></asp:Label>
        <asp:TextBox ID="txtDirectors" runat="server" style="z-index: 1; left: 595px; top: 142px; position: absolute" width="120px"></asp:TextBox>
        <asp:Label ID="lblWriter" runat="server" style="z-index: 1; left: 495px; top: 173px; position: absolute; width: 51px;" Text="Writers:"></asp:Label>
        <asp:TextBox ID="txtWriters" runat="server" style="z-index: 1; left: 595px; top: 172px; position: absolute" width="120px"></asp:TextBox>
         <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 338px; top: 229px; position: absolute" width="120px"></asp:TextBox>
        <p>
            <asp:Label ID="lblStarActors" runat="server" style="z-index: 1; left: 495px; top: 202px; position: absolute; " Text="Star Actors:" height="18"></asp:Label>
        </p>
        <asp:TextBox ID="txtStarActors" runat="server" style="z-index: 1; left: 595px; top: 200px; position: absolute" width="120px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 235px; top: 328px; position: absolute" Text="OK" width="60px" />
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 495px; top: 262px; position: absolute" Text="Description:"></asp:Label>
        <p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 320px; top: 328px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 236px; top: 366px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtCoverImage" runat="server" style="z-index: 1; left: 595px; top: 229px; position: absolute" width="120px"></asp:TextBox>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
