using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();
        AProduct = (clsProduct)Session["AProduct"];
        Response.Write("Title : " + AProduct.Title + "\n");
        Response.Write("Description : " + AProduct.Description + "\n");
        Response.Write("Price : " + AProduct.Price + "\n");
        Response.Write("Condition : " + AProduct.Condition + "\n");
        Response.Write("Availibility : " + AProduct.Availability + "\n");
        Response.Write("Date Listed : " + AProduct.DateListed + "\n");


    }
}