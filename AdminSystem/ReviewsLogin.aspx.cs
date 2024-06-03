using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReviewLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsReviewAdmin AnAdmin = new clsReviewAdmin();

        string Adminname = txtAdminname.Text;
        string Password = txtPassword.Text;

        Boolean Found = false;

        Adminname = Convert.ToString(txtAdminname.Text);
        Password = Convert.ToString(txtPassword.Text);

        Found = AnAdmin.FindAdmin(Adminname, Password);

        Session["AnAdmin"] = AnAdmin;

        if (txtAdminname.Text == "")
        {
            lblError.Text = "Please Enter Admin Name";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Please Enter Password";
        }

        else if (Found == true)
        {
            Response.Redirect("ReviewsList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Details are Incorrect.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}