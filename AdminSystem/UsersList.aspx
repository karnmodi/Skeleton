<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:ListBox ID="lstUsersList" runat="server" style="z-index: 1; left: 16px; top: 68px; position: absolute; height: 332px; width: 385px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 62px; top: 456px; position: absolute;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 146px; top: 457px; position: absolute;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 243px; top: 459px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 91px; top: 560px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 38px; top: 599px; position: absolute;" Text="Apply Filter" />
        <asp:Button ID="lblClearFilter" runat="server" OnClick="lblClearFilter_Click" style="z-index: 1; left: 191px; top: 598px; position: absolute" Text="Clear Filter" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 341px; top: 559px; position: absolute"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 113px; top: 519px; position: absolute" Text="Enter Username"></asp:Label>
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 373px; top: 456px; position: absolute" Text="Main Menu" />
    </form>
</body>
</html>
