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
        if(IsPostBack == false)
        {
            DisplayProducts();
        }

    }

    void DisplayProducts()
    {
        clsProductCollection AllProducts = new clsProductCollection();
        lstProductsList.DataSource = AllProducts.ProductList;
        lstProductsList.DataValueField = "Title";
        lstProductsList.DataTextField = "Price";
        lstProductsList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductID"] = -1;
        Response.Redirect("ProductsDataEntry.aspx");
    }
}