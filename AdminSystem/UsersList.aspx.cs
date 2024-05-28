using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayUserss();
        }


    }

    void DisplayUserss()
    {
        clsUserCollection AllUserss = new clsUserCollection();
        lstUsersList.DataSource = AllUserss.UserList;
        lstUsersList.DataValueField = "UserID";
        lstUsersList.DataTextField = "Username";
        lstUsersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["UserID"] = -1;
        Response.Redirect("UsersDataEntry.aspx");
    }
}