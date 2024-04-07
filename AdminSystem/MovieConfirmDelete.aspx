<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MovieConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 17px; top: 52px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 82px; top: 82px; position: absolute; right: 592px;" Text="Yes!" />
        <p>
            <asp:Button ID="btnNo" runat="server" height="26px" OnClick="btnNo_Click" style="z-index: 1; left: 164px; top: 82px; position: absolute" Text="No!" width="40px" />
        </p>
    </form>
</body>
</html>
