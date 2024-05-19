<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblReviewID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; bottom: 530px" Text="ReviewID" width="114px"></asp:Label>
            <asp:TextBox ID="txtReviewID" runat="server" style="z-index: 1; left: 130px; top: 15px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnfind" runat="server" style="z-index: 1; left: 350px; top: 15px; position: absolute" Text="Find" OnClick="btnFind_Click" />
            <br />
            <br />
            <asp:Label ID="lblCategory" runat="server" style="z-index: 1; left: 10px; top: 59px; position: absolute; right: 884px" Text="Category" width="114px"></asp:Label>
            <asp:TextBox ID="txtCategory" runat="server" style="z-index: 1; left: 130px; top: 59px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 10px; top: 103px; position: absolute" Text="Rating" width="114px"></asp:Label>
            <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 130px; top: 103px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblComment" runat="server" style="z-index: 1; left: 10px; top: 147px; position: absolute" Text="Comment" width="114px"></asp:Label>
            <asp:TextBox ID="txtComment" runat="server" style="z-index: 1; left: 130px; top: 147px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDatePosted" runat="server" style="z-index: 1; left: 10px; top: 191px; position: absolute" Text="DatePosted" width="114px"></asp:Label>
            <asp:TextBox ID="txtDatePosted" runat="server" style="z-index: 1; left: 130px; top: 191px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:CheckBox ID="chkRecent" runat="server" style="z-index: 1; left: 10px; top: 253px; position: absolute" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 297px; position: absolute"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 50px; top: 343px; position: absolute" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 190px; top: 343px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </div>

    </form>
</body>
</html>
