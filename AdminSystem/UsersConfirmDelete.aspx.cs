using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 UserID;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserID = Convert.ToInt32(Session["UserID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsUserCollection AllUsers = new clsUserCollection();
        AllUsers.ThisUser.Find(UserID);
        AllUsers.Delete();
        Response.Redirect("UsersList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("UsersList.aspx");
    }
}