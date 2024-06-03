<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <br>
                        <br >
                        <br />
            <br>
            <asp:Label ID="lblReviewID" runat="server" style="z-index: 1; left: 9px; top: 43px; position: absolute; bottom: 502px" Text="ReviewID" width="114px"></asp:Label>
            <asp:TextBox ID="txtReviewID" runat="server" style="z-index: 1; left: 135px; top: 44px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnfind" runat="server" style="z-index: 1; left: 365px; top: 47px; position: absolute" Text="Find" OnClick="btnFind_Click" />
            <br />
            <br />
            <asp:Label ID="lblCategory" runat="server" style="z-index: 1; left: 8px; top: 96px; position: absolute; right: 922px" Text="Category" width="114px"></asp:Label>
            <asp:TextBox ID="txtCategory" runat="server" style="z-index: 1; left: 148px; top: 98px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblRating" runat="server" style="z-index: 1; left: 11px; top: 149px; position: absolute" Text="Rating" width="114px"></asp:Label>
            <asp:TextBox ID="txtRating" runat="server" style="z-index: 1; left: 146px; top: 147px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnRMM" runat="server" OnClick="btnRMM_Click" style="z-index: 1; left: 361px; top: 432px; position: absolute" Text="Return to the Main Menu" />
            <br />
            <br />
            <asp:Label ID="lblComment" runat="server" style="z-index: 1; left: 10px; top: 199px; position: absolute" Text="Comment" width="114px"></asp:Label>
            <asp:TextBox ID="txtComment" runat="server" style="z-index: 1; left: 147px; top: 196px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDatePosted" runat="server" style="z-index: 1; left: 11px; top: 253px; position: absolute" Text="DatePosted" width="114px"></asp:Label>
            <asp:TextBox ID="txtDatePosted" runat="server" style="z-index: 1; left: 147px; top: 254px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:CheckBox ID="chkRecent" runat="server" style="z-index: 1; left: 15px; top: 303px; position: absolute" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 365px; position: absolute"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 49px; top: 432px; position: absolute" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 189px; top: 433px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </div>

    </form>
</body>
</html>
