using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCart Acart = new clsCart();
        Acart.CartID = Convert.ToInt32(txtCartID.Text);
        Acart.CartDiscription = txtCartDiscription.Text;
        Acart.TotalPrice = Convert.ToInt32(txtTotalPrice.Text);
        Acart.Quantity = Convert.ToInt32(txtQuantity.Text);
        Acart.Active = Convert.ToBoolean(checkActive.Checked);
        Acart.DateAdded = Convert.ToDateTime(txtDateAdded.Text);

        Session["ACart"] = Acart;
        Response.Redirect("CartViewer.aspx");

    }

    protected void checkActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        clsCart Acart = new clsCart();
        Int32 CartID;
        
        Boolean Found = false;
        CartID=Convert.ToInt32(txtCartID.Text);
        Found = Acart.Find(CartID);

        if (Found == true) 
        {
            txtCartDiscription.Text = Acart.CartDiscription;
            txtDateAdded.Text = Acart.DateAdded.ToString();
            txtQuantity.Text = Acart.Quantity.ToString();
            checkActive.Checked = Acart.Active;
            txtTotalPrice.Text = Acart.TotalPrice.ToString();
        }
    }
}