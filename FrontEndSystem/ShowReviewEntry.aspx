<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowReviewEntry.aspx.cs" Inherits="ShowReviewEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Review Entry</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="lblShowId" runat="server" style="z-index: 1; left: 10px; top: 66px; position: absolute" Text="Show ID"></asp:Label>
        <asp:TextBox ID="txtShowId" runat="server" style="z-index: 1; left: 131px; top: 63px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 312px; top: 47px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <p>
        <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 10px; top: 184px; position: absolute" Text="Rating"></asp:Label>
        <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 131px; top: 181px; position: absolute"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="lblComment" runat="server" style="z-index: 1; left: 10px; top: 217px; position: absolute" Text="Comment"></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="txtComment" runat="server" style="z-index: 1; left: 131px; top: 219px; position: absolute; height: 92px; width: 252px; bottom: 357px" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 13px; top: 336px; position: absolute" Text="OK" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 95px; top: 338px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 381px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
