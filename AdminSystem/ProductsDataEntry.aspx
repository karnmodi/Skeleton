<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products Data Entry Page.</title>
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
            width: 400px;
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
        input[type="text"], input[type="number"], input[type="date"] {
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
            width: 100%;
            box-sizing: border-box;
        }
        .buttons {
            display: flex;
            justify-content: space-between;
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
            background-color: #6c757d;
        }
        .cancel-button:hover {
            background-color: #5a6268;
        }
        .error {
            color: red;
            margin-top: 10px;
        }
        .logout-container {
            display: flex;
            justify-content: flex-end;
            align-items: center;
            margin-bottom: 20px;
        }
    </style>
</head>
<body style="height: 668px">

    <form id="form1" runat="server">
        <div class="container">
            <h2>Product Data Entry</h2>

                <asp:Label ID="lblLoggedIn" runat="server" Text="Label"></asp:Label>
            <div class="logout-container">
                <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="LogOut" />
            </div>

            <div class="form-group">
                <label for="txtProductID">Product ID</label>
                <asp:TextBox ID="txtProductID" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtTitle">Title</label>
                <asp:TextBox ID="txtTitle" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtDescription">Description</label>
                <asp:TextBox ID="txtDescription" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtPrice">Price</label>
                <asp:TextBox ID="txtPrice" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtCondition">Condition</label>
                <asp:TextBox ID="txtCondition" runat="server" />
            </div>

            <div class="form-group">
                <label for="chkAvailable">Availability</label>
                <asp:CheckBox ID="chkAvailable" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtDate">Date</label>
                <asp:TextBox ID="txtDate" runat="server" />
            </div>

            <asp:Label ID="lblError" runat="server" CssClass="error" />

            <div class="buttons">
                <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="cancel-button" OnClick="btnCancel_Click" />
                <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            </div>
        </div>
    </form>
</body>
</html>
