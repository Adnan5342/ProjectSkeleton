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
    </form>
</body>
</html>
