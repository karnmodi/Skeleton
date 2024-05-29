<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:ListBox ID="lstReviewList" runat="server" Height="295px" Width="320px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 31px; top: 342px; position: absolute;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 146px; top: 343px; position: absolute;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 265px; top: 344px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:TextBox ID="txtComment" runat="server" style="z-index: 1; left: 78px; top: 443px; position: absolute"></asp:TextBox>
        <asp:Button ID="lblClearFilter" runat="server" OnClick="lblClearFilter_Click" style="z-index: 1; left: 201px; top: 495px; position: absolute; width: 87px;" Text="Clear Filter" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 274px; top: 407px; position: absolute"></asp:Label>
        <asp:Label ID="lblReview" runat="server" style="z-index: 1; left: 98px; top: 404px; position: absolute" Text="Enter Comment"></asp:Label>
        
        </div>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 31px; top: 493px; position: absolute; width: 92px;" Text="Apply Filter" />
    </form>
</body>
</html>
