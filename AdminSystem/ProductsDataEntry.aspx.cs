using System;
using System.Activities.Expressions;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();
        AProduct.Title = txtTitle.Text;
        AProduct.Description = txtDescription.Text;
        AProduct.Price = Convert.ToDouble(txtPrice.Text);
        AProduct.Condition = txtCondition.Text;
        AProduct.Availability = chkAvailable.Checked;
        AProduct.DateListed = Convert.ToDateTime(DateTime.Now);
        Session["AProduct"] = AProduct;
        Response.Redirect("ProductsViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

        clsProduct AProduct = new clsProduct();

        Int32 ProductID;
        Boolean Found = false;
        ProductID = Convert.ToInt32(txtProductID.Text);

        Found = AProduct.Find(ProductID);

        if(Found == true)
        {
            txtTitle.Text = AProduct.Title;
            txtDescription.Text = AProduct.Description;
            txtPrice.Text = AProduct.Price.ToString();
            txtCondition.Text = AProduct.Condition;
            chkAvailable.Checked = AProduct.Availability;
            txtDate.Text = AProduct.DateListed.ToString();

        }


    }
}