using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 CartID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CartID = Convert.ToInt32(Session["CartID"]);
    
}

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        clsCartCollection AllCarts = new clsCartCollection();
        AllCarts.ThisCart.Find(CartID);
        AllCarts.Delete();
        Response.Redirect("CartList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CartList.aspx");
    }
}