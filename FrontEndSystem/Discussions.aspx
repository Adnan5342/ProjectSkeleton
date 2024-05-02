<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Discussions.aspx.cs" Inherits="Discussions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Discussion Board</title>
    <link rel="stylesheet" href="css/Styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 10px; top: 34px; position: absolute; right: 1146px;" OnClick="imgBtnLogo_Click" />
        <p>
            &nbsp;</p>
        <div>
        <asp:ImageButton ID="imgBtnProfile" runat="server" ImageUrl="~/Images/ProfileIcon.png" OnClick="imgBtnProfile_Click" style="z-index: 1; left: 807px; top: 66px; position: absolute; height: 50px; " />
            <asp:Label ID="lblDate4" runat="server" style="z-index: 1; left: 797px; top: 406px; position: absolute" Text="Date posted: "></asp:Label>
        <asp:Label ID="lblTitle" runat="server" SelectionMode="Single" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 356px; top: 74px; position: absolute" Text="Discussion Board"></asp:Label>
        </div>
        <asp:Label ID="lblMessageText1" runat="server" style="z-index: 1; left: 34px; top: 598px; width: 750px; height: 50px; position: absolute" BorderStyle="Solid" Font-Bold="True" Font-Italic="True"></asp:Label>
        <asp:Label ID="lblMessageText2" runat="server" style="z-index: 1; left: 34px; top: 523px; width: 750px; height: 50px; position: absolute" BorderStyle="Solid" Font-Bold="True" Font-Italic="True"></asp:Label>
        <asp:Label ID="lblMessageText3" runat="server" style="z-index: 1; left: 34px; top: 452px; width: 750px; height: 50px; position: absolute" BorderStyle="Solid" Font-Bold="True" Font-Italic="True"></asp:Label>
        <asp:Label ID="lblMessageText4" runat="server" style="z-index: 1; left: 34px; top: 375px; width: 750px; height: 50px; position: absolute" BorderStyle="Solid" Font-Bold="True" Font-Italic="True"></asp:Label>
        <asp:Label ID="lblMessageText5" runat="server" style="z-index: 1; left: 34px; top: 301px; width: 750px; height: 50px; position: absolute" BorderStyle="Solid" Font-Bold="True" Font-Italic="True"></asp:Label>
        <asp:Label ID="lblMessageText6" runat="server" style="z-index: 1; left: 34px; top: 233px; width: 750px; height: 50px; position: absolute" BorderStyle="Solid" Font-Bold="True" Font-Italic="True"></asp:Label>
        <asp:Label ID="lblDate7" runat="server" style="z-index: 1; left: 797px; top: 189px; position: absolute" Text="Date posted: "></asp:Label>
        <asp:Label ID="lblMessageText7" runat="server" style="z-index: 1; left: 34px; top: 159px; width: 750px; height: 50px; position: absolute" BorderStyle="Solid" Font-Bold="True" Font-Italic="True"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 34px; top: 677px; position: absolute" Text="Write a message" />
        <asp:Label ID="lblErrorEx" runat="server" style="z-index: 1; left: 230px; top: 681px; position: absolute"></asp:Label>
        <asp:Label ID="lblUserId1" runat="server" style="z-index: 1; left: 797px; top: 605px; position: absolute">User ID: </asp:Label>
        <asp:Label ID="lblUserId2" runat="server" style="z-index: 1; left: 797px; top: 529px; position: absolute">User ID: </asp:Label>
        <asp:Label ID="lblUserId3" runat="server" style="z-index: 1; left: 797px; top: 459px; position: absolute">User ID: </asp:Label>
        <asp:Label ID="lblUserId4" runat="server" style="z-index: 1; left: 797px; top: 382px; position: absolute">User ID: </asp:Label>
        <asp:Label ID="lblUserId5" runat="server" style="z-index: 1; left: 797px; top: 308px; position: absolute">User ID: </asp:Label>
        <asp:Label ID="lblUserId6" runat="server" style="z-index: 1; left: 797px; top: 240px; position: absolute">User ID: </asp:Label>
        <asp:Label ID="lblUserId7" runat="server" style="z-index: 1; left: 797px; top: 167px; position: absolute">User ID: </asp:Label>
        <asp:Label ID="lblDate1" runat="server" style="z-index: 1; left: 797px; top: 628px; position: absolute" Text="Date posted: "></asp:Label>
        <asp:Label ID="lblDate2" runat="server" style="z-index: 1; left: 797px; top: 553px; position: absolute" Text="Date posted: "></asp:Label>
        <asp:Label ID="lblDate3" runat="server" style="z-index: 1; left: 797px; top: 483px; position: absolute" Text="Date posted: "></asp:Label>
        <asp:Label ID="lblDate5" runat="server" style="z-index: 1; left: 797px; top: 330px; position: absolute" Text="Date posted: "></asp:Label>
        <asp:Label ID="lblDate6" runat="server" style="z-index: 1; left: 797px; top: 263px; position: absolute" Text="Date posted: "></asp:Label>
    </form>
</body>
</html>
