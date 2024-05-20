<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstProductsList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 285px; width: 406px"></asp:ListBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 120px; top: 335px; position: absolute; height: 33px; width: 48px;" Text="Edit" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 60px; top: 389px; position: absolute"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 337px; position: absolute; height: 29px;" Text="Add" />
    </form>
</body>
</html>
