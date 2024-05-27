<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style =" height:534px">
            <asp:ListBox ID="lstProductsList" runat="server" style="z-index: 1; left: 11px; top: 15px; position: absolute; height: 285px; width: 406px"></asp:ListBox>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 180px; top: 335px; position: absolute; height: 29px; width: 48px;" Text="Edit" />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 36px; top: 506px; position: absolute"></asp:Label>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 35px; top: 417px; position: absolute; width: 182px; right: 81px" Text="Enter a Product Name "></asp:Label>
            <asp:TextBox ID="txtFilterBox" runat="server" OnTextChanged="txtFilterBox_TextChanged" style="z-index: 1; left: 231px; top: 416px; position: absolute"></asp:TextBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 30px; top: 337px; position: absolute; height: 29px;  width: 48px; " Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 330px; top: 338px; position: absolute; width: 52px" Text="Delete" height="29px" />
    </form>
</body>
</html>
