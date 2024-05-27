<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 382px; width: 512px;">
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 257px; top: 237px; position: absolute; height: 29px; width: 42px;" Text="No" OnClick="btnNo_Click" />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 144px; top: 239px; position: absolute" Text="Yes" />
            <asp:Label ID="lbltext" runat="server" style="z-index: 1; left: 117px; top: 165px; position: absolute; width: 279px" Text="Are you sure,<br> You want to Delete this Product?"></asp:Label>
        </div>
    </form>
</body>
</html>
