<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberList.aspx.cs" Inherits="MemberList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Member Management</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 16px; top: 133px; position: absolute" Text="Registered Members"></asp:Label>
        </div>
            <asp:ListBox ID="lstMemberList" runat="server" style="z-index: 1; left: 15px; top: 170px; position: absolute; height: 407px; width: 531px"></asp:ListBox>
        <p>
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 16px; top: 594px; position: absolute" Text="Delete user" width="136px" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 177px; top: 594px; position: absolute"></asp:Label>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 12px; top: 17px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
    </form>
</body>
</html>
