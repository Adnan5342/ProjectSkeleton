<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MovieReviewEntry.aspx.vb" Inherits="ReviewEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblReviewId" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Review ID"></asp:Label>
        <asp:Label ID="lblMovieId" runat="server" style="z-index: 1; left: 10px; top: 70px; position: absolute" Text="Movie ID"></asp:Label>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 10px; top: 108px; position: absolute; right: 1089px;" Text="Rating"></asp:Label>
        <p>
            <asp:Label ID="lblComment" runat="server" style="z-index: 1; left: 10px; top: 156px; position: absolute; right: 1057px" Text="Comment"></asp:Label>
        </p>
        <asp:TextBox ID="txtReviewId" runat="server" style="z-index: 1; left: 105px; top: 35px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtMovieId" runat="server" style="z-index: 1; left: 106px; top: 68px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 105px; top: 107px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtComment" runat="server" style="z-index: 1; left: 108px; top: 157px; position: absolute; height: 60px; width: 216px"></asp:TextBox>
    </form>
</body>
</html>
