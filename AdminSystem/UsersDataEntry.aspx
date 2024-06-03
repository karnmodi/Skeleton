<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 521px">
            <asp:Label ID="lblUserID" runat="server" style="z-index: 1; left: 11px; top: 62px; position: absolute; bottom: 483px" Text="UserID" width="114px"></asp:Label>
            <asp:TextBox ID="txtUserID" runat="server" style="z-index: 1; left: 130px; top: 61px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 357px; top: 58px; position: absolute" Text="Find" OnClick="btnFind_Click" />
            <br />
            <br />
            <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 9px; top: 105px; position: absolute; right: 771px" Text="Username" width="114px"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 126px; top: 104px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 11px; top: 154px; position: absolute" Text="Email" width="114px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 131px; top: 154px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 11px; top: 210px; position: absolute" Text="Password" width="114px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 129px; top: 208px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 9px; top: 260px; position: absolute" Text="Address" width="114px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 132px; top: 259px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 11px; top: 305px; position: absolute; bottom: 240px" Text="Phone" width="114px"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 130px; top: 305px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 10px; top: 353px; position: absolute; bottom: 197px" Text="DateAdded" width="114px"></asp:Label>
            <br />
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 131px; top: 349px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 131px; top: 401px; position: absolute" />
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 364px; top: 482px; position: absolute" Text="Main Menu" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 434px; position: absolute"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 51px; top: 483px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 192px; top: 480px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
