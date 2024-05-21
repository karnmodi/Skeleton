<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUserID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; bottom: 530px" Text="UserID" width="114px"></asp:Label>
            <asp:TextBox ID="txtUserID" runat="server" style="z-index: 1; left: 130px; top: 15px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 350px; top: 15px; position: absolute" Text="Find" OnClick="btnFind_Click" />
            <br />
            <br />
            <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 10px; top: 59px; position: absolute; right: 884px" Text="Username" width="114px"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 130px; top: 59px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 103px; position: absolute" Text="Email" width="114px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 130px; top: 103px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 10px; top: 147px; position: absolute" Text="Password" width="114px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 130px; top: 147px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 191px; position: absolute" Text="Address" width="114px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 130px; top: 191px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 10px; top: 235px; position: absolute; bottom: 310px" Text="Phone" width="114px"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 130px; top: 235px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 10px; position: absolute; bottom: 271px" Text="DateAdded" width="114px"></asp:Label>
            <br />
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 130px; top: 279px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 10px; top: 323px; position: absolute" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 367px; position: absolute"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 50px; top: 413px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 190px; top: 413px; position: absolute" Text="Cancel" />
        </div>
    </form>
</body>
</html>
