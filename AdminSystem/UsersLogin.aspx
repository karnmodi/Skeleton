﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersLogin.aspx.cs" Inherits="UsersLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute" Text="Users Login Page"></asp:Label>
        <asp:Label ID="lblAdminName" runat="server" style="z-index: 1; left: 39px; top: 117px; position: absolute" Text="Username: "></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 41px; top: 171px; position: absolute" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 169px; top: 120px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 166px; top: 168px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 130px; top: 235px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 65px; top: 298px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 194px; top: 298px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
