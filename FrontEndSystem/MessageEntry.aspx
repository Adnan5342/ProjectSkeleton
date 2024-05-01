<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MessageEntry.aspx.cs" Inherits="MessageEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMemberId" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; bottom: 661px" Text="Member ID: "></asp:Label>
        <asp:Label ID="lblDatePosted" runat="server" style="z-index: 1; left: 10px; top: 62px; position: absolute" Text="Date Posted: "></asp:Label>
        <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 10px; top: 93px; position: absolute" Text="Enter message here: "></asp:Label>
        <asp:TextBox ID="txtMemberId" runat="server" height="22" style="z-index: 1; left: 101px; position: absolute; bottom: 659px; width: 34px"></asp:TextBox>
        <asp:TextBox ID="txtDatePosted" runat="server" style="z-index: 1; left: 101px; top: 61px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtMessage" runat="server" style="z-index: 1; left: 10px; top: 120px; position: absolute; height: 72px; width: 342px"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 10px; top: 208px; position: absolute" Text="Submit" />
        <p>
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 378px; top: 43px; position: absolute" OnClick="imgBtnLogo_Click" />
        </p>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 96px; top: 208px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
