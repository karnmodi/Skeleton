using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsProductCollection AllProducts = new clsProductCollection();
        AllProducts.ThisProduct.Find(ProductID);
        AllProducts.Delete();
        Response.Redirect("ProductsList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductsList.aspx");

    }
}