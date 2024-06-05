<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CartList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Add" runat="server" OnClick="Add_Click" style="z-index: 1; left: 53px; top: 391px; position: absolute" Text="Add" />
        <asp:Button ID="Edit" runat="server" OnClick="Edit_Click" style="z-index: 1; left: 196px; top: 393px; position: absolute" Text="Edit" />
        <asp:Button ID="Delete" runat="server" OnClick="Delete_Click" style="z-index: 1; top: 392px; position: absolute; left: 341px" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 390px; top: 340px; position: absolute"></asp:Label>
        <asp:Button ID="btnApplyFIlter" runat="server" OnClick="btnApplyFIlter_Click" style="z-index: 1; left: 72px; top: 534px; position: absolute" Text="Apply Filter" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 109px; top: 456px; position: absolute; height: 22px" Text="Enter Cart Description to Filter"></asp:Label>
        <asp:TextBox ID="txtCartDescription" runat="server" style="z-index: 1; left: 123px; top: 486px; position: absolute; width: 216px"></asp:TextBox>
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 259px; top: 534px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnMENU" runat="server" OnClick="btnMENU_Click" style="z-index: 1; left: 405px; top: 476px; position: absolute" Text="Main Menu" />
        <asp:ListBox ID="lstCartBox" runat="server" style="z-index: 1; left: 15px; top: 54px; position: absolute; height: 327px; width: 368px"></asp:ListBox>
    </form>
</body>
</html>
