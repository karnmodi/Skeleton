<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 669px;
        }
    </style>
</head>
<body style="height: 668px">

    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 10px; top: 39px; position: absolute" Text="Prodcut ID"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 114px; top: 37px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 10px; top: 97px; position: absolute" Text="Title" width="86px"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 113px; top: 97px; position: absolute"></asp:TextBox>

        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 10px; position: absolute; right: 1073px; top: 157px;" Text="Description" width="86px"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 110px; top: 157px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 109px; top: 217px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 10px; top: 215px; position: absolute" Text="Price" width="86px"></asp:Label>
            <asp:TextBox ID="txtCondition" runat="server" style="z-index: 1; left: 107px; top: 267px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblCondition" runat="server" style="z-index: 1; left: 10px; top: 268px; position: absolute" Text="Condition" width="86px"></asp:Label>
        <asp:Label ID="lblAvaibility" runat="server" style="z-index: 1; left: 10px; top: 318px; position: absolute" Text="Avaibility" width="86px"></asp:Label>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 10px; position: absolute; top: 374px" Text="Date" width="86px"></asp:Label>

            <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 102px; top: 374px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="margin:10px; z-index: 1; left: 16px; top: 431px; position: absolute; width: 388px; height: 40px;" ForeColor="Red" BorderStyle="None" BorderWidth="1px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="width:fit-content; z-index : 1; left: 46px; top: 501px; position: absolute; right: 710px;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 501px; position: absolute; left: 128px" Text="cancel" />
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 103px; top: 318px; position: absolute" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 330px; top: 37px; position: absolute; width: 72px" Text="Find" />
    </form>
</body>
</html>
