using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductsLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsProductAdmin AnAdmin = new clsProductAdmin();

        string AdminName = txtAdminName.Text;
        string Password = txtPassword.Text;

        Boolean Found = false;

        AdminName = Convert.ToString(txtAdminName.Text);
        Password = Convert.ToString(txtPassword.Text);

        Found = AnAdmin.FindAdmin(AdminName, Password);
        if (txtAdminName.Text == "")
        {
            lblError.Text = "Enter Admin Name ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter Password";
        }

        else if (Found == true)
        {
            Response.Redirect("ProductsList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login Details are incorrect,\n Please Try again.";
        }

    }
}