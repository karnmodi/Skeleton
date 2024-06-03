<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Deletion Confirmation page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            background-color: #f4f4f9;
            margin: 0;
        }
        .container {
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            padding: 20px;
            text-align: center;
            width: 400px;
        }
        .container h2 {
            margin-top: 0;
        }
        .buttons {
            margin-top: 20px;
        }
        .buttons button {
            background-color: #007bff;
            border: none;
            border-radius: 4px;
            color: white;
            cursor: pointer;
            font-size: 16px;
            margin: 5px;
            padding: 10px 20px;
            transition: background-color 0.3s;
        }
        .buttons button:hover {
            background-color: #0056b3;
        }
        .buttons button#btnNo {
            background-color: #6c757d;
        }
        .buttons button#btnNo:hover {
            background-color: #5a6268;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
            <h2>Confirm Deletion</h2>
            <asp:Label ID="lbltext" runat="server" Text="Are you sure you want to delete this product?"></asp:Label>
            <div class="buttons">
                <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
                <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
            </div>
        </div>
    </form>
</body>
</html>
