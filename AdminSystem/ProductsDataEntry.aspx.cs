using System;
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
        AProduct.Descripiton = txtDescription.Text;
        AProduct.Price = Convert.ToDouble(txtPrice.Text);
        AProduct.Condition = txtCondition.Text;
        AProduct.Availability = chkAvailable.Checked;
        AProduct.DateListed = Convert.ToDateTime(DateTime.Now);
        Session["AProduct"] = AProduct;
        Response.Redirect("ProductsViewer.aspx");

    }
}