using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 CartID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CartID = Convert.ToInt32(Session["CartID"]);
        if (IsPostBack == false)
        {
            if (CartID != -1)
            {
                DisplayCart();
            }
        }

        /*clsCartAdmin AnAdmin = new clsCartAdmin();
        AnAdmin = (clsCartAdmin)Session["AnAdmin"];
        Response.Write("Logged in as : " + AnAdmin.Adminname);*/
    }

    void DisplayCart()
    {
        clsCartCollection CartsAll = new clsCartCollection();
        CartsAll.ThisCart.Find(CartID);

        txtCartID.Text = CartsAll.ThisCart.CartID.ToString();
        txtCartDiscription.Text = CartsAll.ThisCart.CartDiscription.ToString();
        txtTotalPrice.Text = CartsAll.ThisCart.TotalPrice.ToString();
        txtQuantity.Text = CartsAll.ThisCart.Quantity.ToString();
        txtDateAdded.Text = CartsAll.ThisCart.DateAdded.ToString();
        checkActive.Checked = CartsAll.ThisCart.Active;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCart ACart = new clsCart();
        string CartDiscription = txtCartDiscription.Text;
        string TotalPrice = txtTotalPrice.Text;
        string Quantity = txtQuantity.Text; 
        string DateAdded = txtDateAdded.Text;
        string Active = Convert.ToBoolean(checkActive.Checked).ToString();

        string Error = "";
        Error = ACart.Valid(CartDiscription, TotalPrice, Quantity, DateAdded, Active);
        if (Error == "")
        {
            ACart.CartID = CartID;
            ACart.CartDiscription = CartDiscription;
            ACart.TotalPrice = Convert.ToInt32(TotalPrice);
            ACart.Quantity = Convert.ToInt32(Quantity);
            ACart.Active = Convert.ToBoolean(Active);
            ACart.DateAdded = Convert.ToDateTime(DateAdded);
            clsCartCollection CartList = new clsCartCollection();
            if (CartID == -1)
            {
                CartList.ThisCart = ACart;
                CartList.Add();
            }
            else
            {
                CartList.ThisCart.Find(CartID);
                CartList.ThisCart = ACart;
                CartList.Update();
            }
            Response.Redirect("CartList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        

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