using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        clsUser AUser = new clsUser();
        AUser = (clsUser)Session["AUser"];
        Response.Write("Username : "+AUser.Username);
        Response.Write(" Email : "+ AUser.Email);
        Response.Write(" Password : "+AUser.Password);
        Response.Write(" Address : "+AUser.Address);
        Response.Write(" Phone : "+ AUser.Phone);
        Response.Write(" DateAddedd : " + AUser.DateAdded);
        Response.Write(" Status : "+ AUser.Active);

    }
}