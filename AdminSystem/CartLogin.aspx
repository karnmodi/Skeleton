<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CartLogin.aspx.cs" Inherits="CartLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblAdminName" runat="server" style="z-index: 1; left: 39px; top: 117px; position: absolute; right: 849px;" Text="Username: "></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 41px; top: 171px; position: absolute; right: 847px;" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 169px; top: 120px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 166px; top: 168px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 376px; top: 178px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 74px; top: 235px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 207px; top: 241px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
<asp:Label ID="lvblCart" runat="server" style="z-index: 1; left: 83px; top: 43px; position: absolute" Text="Cart Login Page" Font-Bold="True" Font-Size="20pt"></asp:Label>
        </p>
    </form>
</body>
</html>
