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
        lblError.Text = Convert.ToString(Session["Message"]);


    }

    void DisplayProducts()
    {
        clsProductCollection AllProducts = new clsProductCollection();
        lstProductsList.DataSource = AllProducts.ProductList;
        lstProductsList.DataValueField = "ProductID";
        lstProductsList.DataTextField = "Title";
        lstProductsList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductID"] = -1;
        Response.Redirect("ProductsDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductID;

        if(lstProductsList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(lstProductsList.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("ProductsDataEntry.aspx");


        }
        else
        {
            lblError.Text = "Please select a Record Form the list to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductID;

        if (lstProductsList.SelectedIndex != -1)
        {
            ProductID  = Convert.ToInt32(lstProductsList.SelectedValue);
            Session["ProductID"] = ProductID;

            Response.Redirect("ProductsConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a product from the List to Delete.";
        }

    }

    protected void txtFilterBox_TextChanged(object sender, EventArgs e)
    {
        clsProductCollection AProduct = new clsProductCollection(); 
        AProduct.ReportByProductName(txtFilterBox.Text);
        lstProductsList.DataSource = AProduct.ProductList;
        lstProductsList.DataValueField = "ProductID";
        lstProductsList.DataTextField = "Title";
        lstProductsList.DataBind();
    }
}