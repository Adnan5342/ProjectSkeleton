<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MovieViewer.aspx.cs" Inherits="MovieViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMovieDetails" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Movie Details"></asp:Label>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 8px; top: 76px; position: absolute" Text="Label"></asp:Label>
        <asp:Image ID="Image1" runat="server" style="z-index: 1; left: 15px; top: 115px; position: absolute" />
    </form>
</body>
</html>
