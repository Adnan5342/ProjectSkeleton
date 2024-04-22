using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MovieReviewEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["memberId"] != null && Session["username"] != null && Session["email"] != null && Session["MovieId"] != null)
        {
            DisplaySessionIDs();
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    void DisplaySessionIDs()
    {
        txtMovieId.Text = Session["MovieId"].ToString();
        txtMemberId.Text = Session["MemberId"].ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsMovieReview AMovieReview = new clsMovieReview();

        Int32 MovieId = Convert.ToInt32(txtMovieId.Text);
        Int32 MemberId = Convert.ToInt32(txtMemberId.Text);
        double Rating = Convert.ToDouble(txtRating.Text);
        string Comment = txtComment.Text;
        string DatePosted = txtDatePosted.Text;

        string Error = "";

        Error = AMovieReview.Valid(Rating, Comment, DatePosted);

        if (Error == "")
        {
            AMovieReview.MovieId = MovieId;
            AMovieReview.MemberId = MemberId;
            AMovieReview.Rating = Rating;
            AMovieReview.Comment = Comment;
            AMovieReview.DatePosted = Convert.ToDateTime(DatePosted);

            Session["AMovieReview"] = AMovieReview;

            Response.Redirect("MovieViewer.aspx");
        }
    }
}