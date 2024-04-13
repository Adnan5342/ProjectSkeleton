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
            <asp:ListBox ID="lstShowList" runat="server" style="z-index: 1; left: 10px; top: 76px; position: absolute; height: 413px; width: 531px"></asp:ListBox>
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Show List"></asp:Label>
        <p>
            <asp:ImageButton ID="imgBtnLogo" runat="server" ImageUrl="~/Images/MovieMindsNetworkLogo.png" style="z-index: 1; left: 569px; top: 154px; position: absolute" />
        <asp:Label ID="lblFilterByTitle" runat="server" style="z-index: 1; left: 569px; top: 76px; position: absolute" Text="Filter by title: "></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 504px; position: absolute" Text="Add new record" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 183px; top: 504px; position: absolute" Text="Edit record" width="136px" height="26px" />
        <asp:TextBox ID="txtFilterByTitle" runat="server" style="z-index: 1; left: 569px; top: 106px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 569px; top: 138px; position: absolute" Text="Apply" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 558px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 355px; top: 504px; position: absolute" Text="Delete record" width="136px" />
        <asp:Button ID="btnClear" runat="server" height="26px" OnClick="btnClear_Click" style="z-index: 1; left: 645px; top: 138px; position: absolute" Text="Clear" width="49px" />
        </p>
        <asp:LinkButton ID="lnkBtnMovies" runat="server" OnClick="lnkBtnMovies_Click" style="z-index: 1; left: 567px; top: 273px; position: absolute">Go to &#39;movies&#39; list</asp:LinkButton>
    </form>
</body>
</html>
