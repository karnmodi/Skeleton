<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product List</title>
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
            width: 450px;
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
        input[type="text"], select, textarea {
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
            margin-bottom: 25px;
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
        .delete-button {
            background-color: #dc3545;
        }
        .delete-button:hover {
            background-color: #c82333;
        }
        .error {
            color: red;
            margin-top: 10px;
        }
        .list-box {
            width: 100%;
            height: 200px;
            border: 1px solid #ccc;
            border-radius: 4px;
            margin-bottom: 15px;
            padding: 10px;
            box-sizing: border-box;
        }
        .logout-container {
            display: flex;
            justify-content: flex-end;
            align-items: center;
            margin-bottom: 20px;
        }
    </style>

    <script type="text/javascript">
        function handleEnterKey(event, target) {
            if (event.key === 'Enter') {
                event.preventDefault();
                __doPostBack(target, '');
            }
        }
    </script>
</head>
<body>
<form id="form1" runat="server">
        <div class="container">
            
            <h2>Product List</h2>
                <asp:Label ID="lblLoggedIn" runat="server" Text="Label"></asp:Label>
            <div class="logout-container">
                <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="LogOut" />
            </div>


            <asp:ListBox ID="lstProductsList" runat="server" CssClass="list-box"></asp:ListBox>

            <div class="buttons">
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="delete-button" OnClick="btnDelete_Click" />
                
            </div>

            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Enter a Product Name" />
                <asp:TextBox ID="txtFilterBox" runat="server" OnTextChanged="txtFilterBox_TextChanged" AutoPostBack="true" onkeydown="handleEnterKey(event, this.id)" />
            </div>

            <asp:Label ID="lblError" runat="server" CssClass="error" />
        </div>
    </form>
</body>
</html>
