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
        string Category = txtCategory.Text;
        string Rating = Convert.ToString(txtRating.Text);
        string Comment = txtComment.Text;
        string DatePosted = txtDatePosted.Text;
        Boolean Recent = chkRecent.Checked;


        string Error = "";
        Error = AReview.Valid(Category, Rating, Comment, DatePosted, Recent);
        if (Error == "")
        {
            AReview.Category = Category;
            AReview.Rating = Convert.ToInt32(Rating);
            AReview.Comment = Comment;
            AReview.DatePosted = Convert.ToDateTime(DatePosted);
            AReview.Recent = Convert.ToBoolean(Recent);
            Session["AReview"] = AReview;
            Response.Redirect("ReviewsViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}