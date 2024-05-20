using System;
using System.Activities.Expressions;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            if (ProductID != -1)
            {
                DisplayProduct();

            }
        }
    }

    void DisplayProduct()
    {
        clsProductCollection ProductCollection = new clsProductCollection();
        ProductCollection.ThisProduct.Find(ProductID);

        txtProductID.Text = ProductCollection.ThisProduct.ProductID.ToString();
        txtTitle.Text = ProductCollection.ThisProduct.Title.ToString();
        txtDescription.Text = ProductCollection.ThisProduct.Description.ToString();
        txtPrice.Text = ProductCollection.ThisProduct.Price.ToString();
        txtCondition.Text = ProductCollection.ThisProduct.Condition.ToString();
        chkAvailable.Checked= ProductCollection.ThisProduct.Availability;
        txtDate.Text = ProductCollection.ThisProduct.DateListed.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsProduct AProduct = new clsProduct();
        string Title = txtTitle.Text;
        string Description = txtDescription.Text;
        string Price = Convert.ToString(txtPrice.Text);
        string Condition = txtCondition.Text;
        string Availability = Convert.ToString(chkAvailable.Checked);
        string DateListed = txtDate.Text;

        string Error = "";
        Error = AProduct.Valid(Title, Description, Price, Condition, Availability, DateListed);
        if(Error == "")
        {
            AProduct.ProductID = ProductID;
            AProduct.Title = Title;
            AProduct.Description = Description;
            AProduct.Price = Convert.ToDouble(Price);
            AProduct.Condition = Condition;
            AProduct.Availability = Convert.ToBoolean(Availability);
            AProduct.DateListed = Convert.ToDateTime(DateListed);
            
            clsProductCollection ProductList = new clsProductCollection();

            if(ProductID == -1)
            {
                ProductList.ThisProduct = AProduct;
                ProductList.Add();
                Session["Message"] = "Data Successufully Added.";
                Response.Redirect("ProductsList.aspx");
            }
            else
            {
                ProductList.ThisProduct.Find(ProductID);
                ProductList.ThisProduct = AProduct;
                ProductList.Update();
                Session["Message"] = "Data Successufully Updated.";
                Response.Redirect("ProductsList.aspx");

            }

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