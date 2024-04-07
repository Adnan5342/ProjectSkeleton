<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
            <asp:ListBox ID="lstShowList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 480px; width: 531px"></asp:ListBox>
        <p>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 569px; top: 131px; position: absolute" />
        </p>
        <p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 504px; position: absolute" Text="Add new record" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 183px; top: 504px; position: absolute" Text="Edit record" width="136px" height="26px" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 558px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
