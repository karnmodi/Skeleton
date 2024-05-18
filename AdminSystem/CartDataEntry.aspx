<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CartDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCart" runat="server" style="z-index: 1; left: 19px; top: 39px; position: absolute; width: 105px" Text="CartID"></asp:Label>
            <asp:TextBox ID="txtCartID" runat="server" style="z-index: 1; left: 139px; top: 33px; position: absolute"></asp:TextBox>
        </div>
        <p>
            <asp:TextBox ID="txtCartDiscription" runat="server" style="z-index: 1; left: 138px; top: 80px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblCartDiscription" runat="server" style="z-index: 1; left: 16px; top: 81px; position: absolute" Text="Cart Discriptiom" width="105px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 18px; top: 181px; position: absolute" Text="DateAdded" width="105px"></asp:Label>
        <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 16px; top: 234px; position: absolute" Text="Total Price" width="105px"></asp:Label>
        <p>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 20px; top: 126px; position: absolute; height: 20px" Text="Quantity" width="105px"></asp:Label>
        </p>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 135px; top: 128px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 138px; top: 181px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 140px; top: 235px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 53px; top: 390px; position: absolute" Text="Ok" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 120px; top: 391px; position: absolute" Text="Cancel" />
        <asp:CheckBox ID="checkActive" runat="server" OnCheckedChanged="checkActive_CheckedChanged" style="z-index: 1; left: 15px; top: 290px; position: absolute" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; position: absolute; top: 339px" Text="Error"></asp:Label>
    </form>
    <p>
&nbsp;</p>
</body>
</html>
