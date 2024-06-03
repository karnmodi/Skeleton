<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Team Main Menu</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            text-align: center;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }

        .main-menu {
            margin-top: 50px;
        }

        h1 {
            font-size: 36px;
            margin-bottom: 20px;
            color: #333;
        }

        p {
            font-size: 18px;
            margin-bottom: 40px;
            color: #666;
        }

        .buttons {
            display: flex;
            justify-content: center;
            flex-wrap: wrap; 
            gap: 20px; 
        }

        asp\:button {
            padding: 15px 30px;
            font-size: 25px;
            cursor: pointer;
            border: 2px solid #007bff; 
            background-color: transparent; 
            color: #007bff; 
            border-radius: 30px;
            transition: all 0.3s ease; 
            outline: none;
        }

        asp\:button:hover {
            background-color: #007bff;
            color: #fff; 
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-menu">
            <h1>Virtual Thrift Store</h1>
            <p>An online marketplace for buying and selling second-hand clothing, accessories, and home goods. </p>
            <div class="buttons">
                <asp:Button ID="btnUsers" runat="server" Text="Users" OnClick="btnUsers_Click" />
                <asp:Button ID="btnProducts" runat="server" Text="Products" OnClick="btnProducts_Click" />
                <asp:Button ID="btnCarts" runat="server" Text="Carts" OnClick="btnCarts_Click"/>
                <asp:Button ID="btnReviews" runat="server" Text="Reviews" OnClick="btnReviews_Click" />
            </div>
        </div>
    </form>
</body>
</html>
