<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MessageEntry.aspx.cs" Inherits="MessageEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Message Entry</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMemberId" runat="server" style="z-index: 1; left: 13px; top: 37px; position: absolute; width: 92px;" Text="Member ID: " height="18"></asp:Label>
        <asp:Label ID="lblDatePosted" runat="server" style="z-index: 1; left: 13px; top: 79px; position: absolute" Text="Date Posted: "></asp:Label>
        <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 10px; top: 152px; position: absolute" Text="Enter message below: "></asp:Label>
        <asp:TextBox ID="txtMemberId" runat="server" style="z-index: 1; left: 106px; position: absolute; width: 34px; height: 13px; top: 37px;"></asp:TextBox>
        <asp:TextBox ID="txtDatePosted" runat="server" style="z-index: 1; left: 105px; top: 74px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtMessage" runat="server" style="z-index: 1; left: 10px; top: 176px; position: absolute; height: 72px; width: 342px"></asp:TextBox>
        <p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 335px; top: 37px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 88px; top: 266px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 301px; position: absolute"></asp:Label>
        <p>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 12px; top: 266px; position: absolute" Text="Submit" />
        </p>
    </form>
</body>
</html>
