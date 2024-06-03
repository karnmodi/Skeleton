using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnProducts_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductsLogin.aspx");
    }

    protected void btnUsers_Click(object sender, EventArgs e)
    {
        Response.Redirect("UsersLogin.aspx");
    }

    protected void btnCarts_Click(object sender, EventArgs e)
    {
        Response.Redirect("CartLogin.aspx");
    }

    protected void btnReviews_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReviewsLogin.aspx");
    }
}