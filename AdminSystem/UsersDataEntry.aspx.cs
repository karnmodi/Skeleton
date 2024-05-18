﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsUser AUser = new clsUser();
        AUser.UserID = Convert.ToInt32(txtUserID.Text);
        AUser.Username = txtUsername.Text;
        AUser.Email= txtEmail.Text;
        AUser.Password= txtPassword.Text;   
        AUser.Address = txtAddress.Text;
        AUser.Phone = txtPhone.Text;
        AUser.Active = Convert.ToBoolean(chkActive.Checked);
        AUser.DateAdded = Convert.ToDateTime(txtDateAdded.Text);

        Session["AUser"] = AUser;
        Response.Redirect("UsersViewer.aspx");
    }
}