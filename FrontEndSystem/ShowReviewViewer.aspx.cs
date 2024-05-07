using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowReviewViewer : System.Web.UI.Page
{
    Int32 ShowReviewId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MemberId"] != null && Session["Username"] != null && Session["Email"] != null && Session["ShowReviewId"] != null)
        {
            ShowReviewId = Convert.ToInt32(Session["ShowReviewId"]);
            if (ShowReviewId != -1 && !IsPostBack)
            {
                DisplayReview();
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    void DisplayReview()
    {
        clsShowReviewCollection ShowReviews = new clsShowReviewCollection();
        ShowReviews.ThisShowReview.Find(ShowReviewId);

        lblShowTitleText.Text = ShowReviews.ThisShowReview.ShowTitle;
        lblUserText.Text = ShowReviews.ThisShowReview.Username;
        lblRatingText.Text = ShowReviews.ThisShowReview.Rating.ToString();
        lblCommentText.Text = ShowReviews.ThisShowReview.Comment;
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowViewer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        clsShowReviewCollection ShowReviews = new clsShowReviewCollection();
        ShowReviews.ThisShowReview.Find(ShowReviewId);

        Int32 ReviewMemberId = Convert.ToInt32(ShowReviews.ThisShowReview.MemberId);
        if (ReviewMemberId == Convert.ToInt32(Session["MemberId"]))
        {
            Response.Redirect("ShowReviewConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "You cannot delete another user's review. ";
        }
    }
}