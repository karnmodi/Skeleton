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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 UserID;
        if (lstUsersList.SelectedIndex != -1)
        {
            UserID = Convert.ToInt32(lstUsersList.SelectedValue);
            Session["UserID"] = UserID;
            Response.Redirect("UsersDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 UserID;
        if (lstUsersList.SelectedIndex != -1)
        {
            UserID = Convert.ToInt32(lstUsersList.SelectedValue);
            Session["UserID"] = UserID;
            Response.Redirect("UsersConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Select Entry.";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsUserCollection AUser = new clsUserCollection();
        AUser.ReportByUsername(txtUserName.Text);
        lstUsersList.DataSource = AUser.UserList;
        lstUsersList.DataValueField = "UserID";
        lstUsersList.DataTextField = "Username";
        lstUsersList.DataBind();
    }

    protected void lblClearFilter_Click(object sender, EventArgs e)
    {
        clsUserCollection AUser = new clsUserCollection();
        AUser.ReportByUsername("");
        txtUserName.Text = "";
        lstUsersList.DataSource = AUser.UserList;
        lstUsersList.DataValueField = "UserID";
        lstUsersList.DataTextField = "Username";
        lstUsersList.DataBind();
    }
}