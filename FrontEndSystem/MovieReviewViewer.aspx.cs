using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class MovieReviewViewer : System.Web.UI.Page
{
    Int32 MovieReviewId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MemberId"] != null && Session["Username"] != null && Session["Email"] != null && Session["MovieReviewId"] != null)
        {
            MovieReviewId = Convert.ToInt32(Session["MovieReviewId"]);
            if (MovieReviewId != -1 && !IsPostBack)
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
        clsMovieReviewCollection MovieReviews = new clsMovieReviewCollection();
        MovieReviews.ThisMovieReview.Find(MovieReviewId);

        lblMovieIdText.Text = MovieReviews.ThisMovieReview.MovieId.ToString();
        lblMemberIdText.Text = MovieReviews.ThisMovieReview.MemberId.ToString();
        lblRatingText.Text = MovieReviews.ThisMovieReview.Rating.ToString();
        lblCommentText.Text = MovieReviews.ThisMovieReview.Comment;
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        clsMovieReviewCollection MovieReviews = new clsMovieReviewCollection();
        MovieReviews.ThisMovieReview.Find(MovieReviewId);

        Int32 ReviewMemberId = Convert.ToInt32(MovieReviews.ThisMovieReview.MemberId);
        if (ReviewMemberId == Convert.ToInt32(Session["MemberId"]))
        {
            Response.Redirect("MovieReviewConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "You cannot delete another user's review. ";
        }
    }
}