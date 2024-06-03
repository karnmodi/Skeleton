<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsLogin.aspx.cs" Inherits="ProductsLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products Login Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            padding: 20px;
            width: 350px;
            box-sizing: border-box;
        }
        h2 {
            text-align: center;
            margin-top: 0;
            color: #333;
        }
        .form-group {
            margin-bottom: 15px;
            display: flex;
            flex-direction: column;
        }
        label {
            margin-bottom: 5px;
            color: #555;
        }
        input[type="text"], input[type="password"] {
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            width: 100%;
            box-sizing: border-box;
        }
        .buttons {
            display: flex;
            justify-content: space-between;
            margin-top: 15px;
        }
        button {
            background-color: #007bff;
            border: none;
            border-radius: 4px;
            color: white;
            padding: 10px 20px;
            cursor: pointer;
            transition: background-color 0.3s;
        }
        button:hover {
            background-color: #0056b3;
        }
        .cancel-button {
            background-color: #dc3545;
        }
        .cancel-button:hover {
            background-color: #c82333;
        }
        .error {
            color: red;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Products Login Page</h2>
            <div class="form-group">
                <asp:Label ID="lblAdminName" runat="server" Text="Admin Name:" AssociatedControlID="txtAdminName" />
                <asp:TextBox ID="txtAdminName" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Password:" AssociatedControlID="txtPassword" />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            </div>
            <asp:Label ID="lblError" runat="server" CssClass="error" />
            <div class="buttons">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="cancel-button" OnClick="btnCancel_Click" />
            </div>
        </div>
    </form>
</body>
</html>
