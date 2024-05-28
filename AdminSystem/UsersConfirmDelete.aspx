<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 <div style="height: 316px; width: 475px;">
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 268px; top: 145px; position: absolute; height: 29px; width: 42px;" Text="No" OnClick="btnNo_Click" />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 65px; top: 145px; position: absolute" Text="Yes" />
            <asp:Label ID="lbltext" runat="server" style="z-index: 1; left: 76px; top: 96px; position: absolute; width: 279px" Text="You want to delete this User??"></asp:Label>
        </div>
    </form>
</body>
</html>
