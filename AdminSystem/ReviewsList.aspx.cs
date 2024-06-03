using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayReviews();
        }
        clsReviewAdmin AnAdmin = new clsReviewAdmin();
        AnAdmin = (clsReviewAdmin)Session["AnAdmin"];
        Response.Write("Logged in as : " + AnAdmin.Adminname);
    }

    void DisplayReviews()
    {
        clsReviewCollection AllReviews = new clsReviewCollection();
        lstReviewList.DataSource = AllReviews.ReviewList;
        lstReviewList.DataValueField = "ReviewID";
        lstReviewList.DataTextField = "Comment";
        lstReviewList.DataBind();
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsReviewCollection AReview = new clsReviewCollection();
        AReview.ReportByReviewComment(txtComment.Text);
        lstReviewList.DataSource = AReview.ReviewList;
        lstReviewList.DataValueField = "ReviewID";
        lstReviewList.DataTextField = "Comment";
        lstReviewList.DataBind();
    }

    protected void lblClearFilter_Click(object sender, EventArgs e)
    {
        clsReviewCollection AReview = new clsReviewCollection();
        AReview.ReportByReviewComment("");
        txtComment.Text = "";
        lstReviewList.DataSource = AReview.ReviewList;
        lstReviewList.DataValueField = "ReviewID";
        lstReviewList.DataTextField = "Comment";
        lstReviewList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ReviewID"] = -1;
        Response.Redirect("ReviewsDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ReviewID;
        if (lstReviewList.SelectedIndex != -1)
        {
            ReviewID = Convert.ToInt32(lstReviewList.SelectedValue);
            Session["ReviewID"] = ReviewID;
            Response.Redirect("ReviewsDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please comment to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ReviewID;
        if (lstReviewList.SelectedIndex != -1)
        {
            ReviewID = Convert.ToInt32(lstReviewList.SelectedValue);
            Session["ReviewID"] = ReviewID;
            Response.Redirect("ReviewsConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Select any comment.";
        }
    }

    protected void btnRMM_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}