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
        string Title = txtTitle.Text;
        string Description = txtDescription.Text;
        string Price = Convert.ToString(txtPrice.Text);
        string Condition = txtCondition.Text;
        string Availability = chkAvailable.Text;
        string DateListed = txtDate.Text;

        string Error = "";
        Error = AProduct.Valid(Title, Description, Price, Condition, DateListed);
        if(Error == "")
        {
            AProduct.Title = Title;
            AProduct.Description = Description;
            AProduct.Price = Convert.ToDouble(Price);
            AProduct.Condition = Condition;
            AProduct.Availability = Convert.ToBoolean(Availability);
            AProduct.DateListed = Convert.ToDateTime(DateListed);
            Session["AProduct"] = AProduct;
            Response.Redirect("ProductsViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

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