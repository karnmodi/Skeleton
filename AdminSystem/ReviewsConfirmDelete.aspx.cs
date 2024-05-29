using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activities;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ReviewID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ReviewID = Convert.ToInt32(Session["ReviewID"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        clsReviewCollection AllReviews = new clsReviewCollection();
        AllReviews.ThisReview.Find(ReviewID);
        AllReviews.Delete();
        Response.Redirect("ReviewsList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReviewsList.aspx");
    }
}