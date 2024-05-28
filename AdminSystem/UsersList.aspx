<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstUsersList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 332px; width: 385px"></asp:ListBox>
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 137px; top: 479px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 224px; top: 388px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 68px; top: 391px; position: absolute;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 144px; top: 390px; position: absolute;" Text="Edit" OnClick="btnEdit_Click" />
    </form>
</body>
</html>
