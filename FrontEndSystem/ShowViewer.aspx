<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowViewer.aspx.cs" Inherits="ShowViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblShowDetails" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Show Details"></asp:Label>
        </div>
        <p>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 8px; top: 76px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
