<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" style="z-index: 1; left: 26px; top: 159px; position: absolute" Text="Yes" />
        <asp:Button ID="BtnNo" runat="server" OnClick="BtnNo_Click" style="z-index: 1; left: 150px; top: 158px; position: absolute" Text="No" />
        <asp:Label ID="lblConfirm" runat="server" style="z-index: 1; left: 16px; top: 84px; position: absolute" Text="Confrim to delete this record"></asp:Label>
    </form>
</body>
</html>
