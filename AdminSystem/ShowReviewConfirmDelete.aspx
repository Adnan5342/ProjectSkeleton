<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowReviewConfirmDelete.aspx.cs" Inherits="ShowReviewConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
        <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 17px; top: 52px; position: absolute" Text="Are you sure you want to delete this review?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" height="26px" OnClick="btnYes_Click" style="z-index: 1; left: 53px; top: 87px; position: absolute" Text="Yes!" width="82px" />
            <asp:Button ID="btnNo" runat="server" height="26px" OnClick="btnNo_Click" style="z-index: 1; left: 164px; top: 87px; position: absolute; width: 82px;" Text="No!" />
        </p>
    </form>
</body>
</html>
