<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsLogin.aspx.cs" Inherits="ProductsLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute" Text="Products Login Page"></asp:Label>
        <asp:Label ID="lblAdminName" runat="server" style="z-index: 1; left: 39px; top: 117px; position: absolute" Text="Admin Name: "></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 41px; top: 171px; position: absolute" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtAdminName" runat="server" style="z-index: 1; left: 169px; top: 120px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 166px; top: 168px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 388px; top: 170px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 64px; top: 241px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 198px; top: 241px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
