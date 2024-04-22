using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MovieViewer : System.Web.UI.Page
{
    Int32 MovieId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["memberId"] != null && Session["username"] != null && Session["email"] != null)
        {
            MovieId = Convert.ToInt32(Session["MovieId"]);
            if (MovieId != -1)
            {
                DisplayMovies();
                DisplayMovieReviews();
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    void DisplayMovies()
    {
        clsMovieCollection Movies = new clsMovieCollection();
        Movies.ThisMovie.Find(MovieId);

        lblTitle.Text = Movies.ThisMovie.Title;
        lblRuntimeText.Text = Movies.ThisMovie.Runtime.ToString();
        lblReleaseDateText.Text = Movies.ThisMovie.ReleaseDate.ToString();
        lblDescriptionText.Text = Movies.ThisMovie.Description;
        lblGenreText.Text = Movies.ThisMovie.Genre;
        lblRatingText.Text = Movies.ThisMovie.Rating.ToString();
        lblDirectorsText.Text = Movies.ThisMovie.Directors;
        lblWritersText.Text = Movies.ThisMovie.Writers;
        lblStarActorsText.Text = Movies.ThisMovie.StarActors;
        imgCoverImage.ImageUrl = Movies.ThisMovie.CoverImage;
    }

    void DisplayMovieReviews()
    {
        clsMovieReviewCollection MovieReviews = new clsMovieReviewCollection();
        MovieReviews.ThisMovieReview.Find(MovieId);

        lstMovieReviewList.DataSource = MovieReviews.MovieReviewList;
        lstMovieReviewList.DataValueField = "MovieReviewId";
        lstMovieReviewList.DataTextField = "Comment";
        lstMovieReviewList.DataBind();
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void imgBtnProfile_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ProfileViewer.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        int movieId = (int)Session["MovieId"];

        Session["MovieId"] = movieId;
        Response.Redirect("MovieReviewEntry.aspx");
    }
}