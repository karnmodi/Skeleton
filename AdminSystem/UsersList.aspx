<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:ListBox ID="lstUsersList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 332px; width: 385px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 68px; top: 391px; position: absolute;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 144px; top: 390px; position: absolute;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 224px; top: 388px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 82px; top: 498px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 40px; top: 553px; position: absolute;" Text="Apply Filter" />
        <asp:Button ID="lblClearFilter" runat="server" OnClick="lblClearFilter_Click" style="z-index: 1; left: 189px; top: 552px; position: absolute" Text="Clear Filter" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 336px; top: 481px; position: absolute"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 105px; top: 458px; position: absolute" Text="Enter Username"></asp:Label>
    </form>
</body>
</html>
