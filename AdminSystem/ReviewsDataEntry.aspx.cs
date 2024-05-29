using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ReviewID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ReviewID = Convert.ToInt32(Session["ReviewID"]);
        if (IsPostBack == false)
        {
            if (ReviewID != -1)
            {
                DisplayReview();
            }
        }
    }

    void DisplayReview()
    {
        clsReviewCollection ReviewsAll = new clsReviewCollection();
        ReviewsAll.ThisReview.Find(ReviewID);

        txtReviewID.Text = ReviewsAll.ThisReview.ReviewID.ToString();
        txtCategory.Text = ReviewsAll.ThisReview.Category.ToString();
        txtRating.Text = ReviewsAll.ThisReview.Rating.ToString();
        txtComment.Text = ReviewsAll.ThisReview.Comment.ToString();
        txtDatePosted.Text = ReviewsAll.ThisReview.DatePosted.ToString();
        chkRecent.Checked = ReviewsAll.ThisReview.Recent;
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
        string Rating = txtRating.Text;
        string Comment = txtComment.Text;
        string DatePosted = txtDatePosted.Text;
        Boolean Recent = Convert.ToBoolean(chkRecent.Checked);


        string Error = "";
        Error = AReview.Valid(Category, Rating, Comment, DatePosted, Recent);
        if (Error == "")
        {
            AReview.ReviewID = ReviewID;
            AReview.Category = Category;
            AReview.Rating = Convert.ToInt32(Rating);
            AReview.Comment = Comment;
            AReview.DatePosted = Convert.ToDateTime(DatePosted);
            AReview.Recent = Convert.ToBoolean(Recent);
            clsReviewCollection ReviewList = new clsReviewCollection();
            if (ReviewID == -1)
            {
                ReviewList.ThisReview = AReview;
                ReviewList.Add();
            }
            else
            {
                ReviewList.ThisReview.Find(ReviewID);
                ReviewList.ThisReview = AReview;
                ReviewList.Update();
            }
            Response.Redirect("ReviewsList.aspx");
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