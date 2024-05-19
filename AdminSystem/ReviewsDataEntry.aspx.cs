using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

        clsReview AReview = new clsReview();
        Int32 ReviewID;
        Boolean Found = false;

        ReviewID = Convert.ToInt32(txtReviewID.Text);
        Found = AReview.Find(ReviewID);

        if (Found == true)
        {
            txtCategory.Text = AReview.Category;
            txtRating.Text = AReview.Rating.ToString();
            txtComment.Text = AReview.Comment;
            txtDatePosted.Text = AReview.DatePosted.ToString();
            chkRecent.Checked = AReview.Recent;
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsReview AReview = new clsReview();
        AReview.ReviewID = Convert.ToInt32(txtReviewID.Text);
        AReview.Category = txtCategory.Text;
        AReview.Rating = Convert.ToInt32(txtRating.Text);
        AReview.Comment = txtComment.Text;
        AReview.Recent = Convert.ToBoolean(chkRecent.Checked);
        AReview.DatePosted = Convert.ToDateTime(txtDatePosted.Text);

        Session["AReview"] = AReview;
        Response.Redirect("ReviewsViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}