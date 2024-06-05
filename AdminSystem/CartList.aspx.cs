using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayCarts();
        }
        /*clsCartAdmin AnAdmin = new clsCartAdmin();
        AnAdmin = (clsCartAdmin)Session["AnAdmin"];
        Response.Write("Logged in as : " + AnAdmin.Adminname);*/
    }
    void DisplayCarts()
    {
        clsCartCollection AllCArt = new clsCartCollection();
        lstCartBox.DataSource = AllCArt.CartList;
        lstCartBox.DataValueField = "CartID";
        lstCartBox.DataTextField= "CartDiscription";
        lstCartBox.DataBind();

    }

    protected void btnMENU_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void Add_Click(object sender, EventArgs e)
    {
        Session["CartID"] = -1;
        Response.Redirect("CartDataEntry.aspx");
    }

    protected void Edit_Click(object sender, EventArgs e)
    {
        Int32 CartID;
        if (lstCartBox.SelectedIndex != -1)
        {
            CartID = Convert.ToInt32(lstCartBox.SelectedValue);
            Session["CartID"] = CartID;
            Response.Redirect("CartDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Select any Cart to Edit.";
        }
    }

    protected void Delete_Click(object sender, EventArgs e)
    {
        Int32 CartID;
        if (lstCartBox.SelectedIndex != -1)
        {
            CartID = Convert.ToInt32(lstCartBox.SelectedValue);
            Session["CartID"] = CartID;
            Response.Redirect("CartConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Select any Cart to Delete..";
        }
    }

    protected void btnApplyFIlter_Click(object sender, EventArgs e)
    {
        clsCartCollection ACart = new clsCartCollection();
        ACart.ReportByCartDescription(txtCartDescription.Text);
        lstCartBox.DataSource = ACart.CartList;
        lstCartBox.DataValueField = "CartID";
        lstCartBox.DataTextField = "CartDiscription";
        lstCartBox.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsCartCollection ACart = new clsCartCollection();
        ACart.ReportByCartDescription("");
        txtCartDescription.Text = "";
        lstCartBox.DataSource = ACart.CartList;
        lstCartBox.DataValueField = "CartID";
        lstCartBox.DataTextField = "CartDiscription";
        lstCartBox.DataBind();
    }
}