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

     clsCart Acart = new clsCart();
        Acart = (clsCart)Session["Acart"];
        Response.Write("CartID : " + Acart.CartID);
        Response.Write("TotalPrice : " + Acart.TotalPrice);
        Response.Write("CartDiscription : " + Acart.CartDiscription);
        Response.Write("Quantity : " + Acart.Quantity);
        Response.Write("DateAdded : " + Acart.DateAdded);
        Response.Write("Active : " + Acart.Active);
    }
}