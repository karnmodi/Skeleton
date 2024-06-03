<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewsLogin.aspx.cs" Inherits="ReviewLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute" Text="Review Login page"></asp:Label>
        <asp:Label ID="lblAdminName" runat="server" style="z-index: 1; left: 22px; top: 104px; position: absolute; right: 916px;" Text="Admin name: "></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 48px; top: 146px; position: absolute" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtAdminname" runat="server" style="z-index: 1; left: 169px; top: 105px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 165px; top: 148px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 376px; top: 151px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 113px; top: 208px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 249px; top: 208px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
