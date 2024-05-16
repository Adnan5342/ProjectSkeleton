using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    Int32 MovieId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] != null && Session["Email"] != null && Session["MovieId"] != null)
        {
            MovieId = Convert.ToInt32(Session["MovieId"]);
            if (MovieId != -1)
            {
                DisplayMovie();
            }
        }
        else
        {
            Response.Redirect("AdminLogin.aspx");
        }
    }

    void DisplayMovie()
    {
        clsMovieCollection Movies = new clsMovieCollection();
        Movies.ThisMovie.Find(MovieId);

        lblTitle.Text = Movies.ThisMovie.Title;
        lblRuntimeText.Text = Movies.ThisMovie.Runtime.ToString();
        lblReleaseDateText.Text = Movies.ThisMovie.ReleaseDate.ToShortDateString();
        lblDescriptionText.Text = Movies.ThisMovie.Description;
        lblGenreText.Text = Movies.ThisMovie.Genre;
        lblRatingText.Text = Movies.ThisMovie.Rating.ToString();
        lblDirectorsText.Text = Movies.ThisMovie.Directors;
        lblWritersText.Text = Movies.ThisMovie.Writers;
        lblStarActorsText.Text = Movies.ThisMovie.StarActors;
        imgCoverImage.ImageUrl = Movies.ThisMovie.CoverImage;
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }

    protected void btnMovieList_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieList.aspx");
    }
}