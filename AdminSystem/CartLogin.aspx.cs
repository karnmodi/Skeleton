using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CartLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsCartAdmin AnAdmin = new clsCartAdmin();
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        Username = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AnAdmin.FindAdmin(Username, Password);
        Session["AnAdmin"] = AnAdmin;
        if (txtUsername.Text == "")
        {
            lblError.Text = "Enter User Name ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter Password";
        }

        else if (Found == true)
        {
            Response.Redirect("CartList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Credentials are Incorrect.Pleach check and Confirm again.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}