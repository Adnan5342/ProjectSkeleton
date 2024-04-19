using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Registration; 
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MovieViewer : System.Web.UI.Page
{
    Int32 MovieId;

    protected void Page_Load(object sender, EventArgs e)
    {
        
            MovieId = Convert.ToInt32(Session["MovieId"]);
            if (MovieId != -1)
            {
                DisplayMovies();
            }
        
    }

    void DisplayMovies()
    {
        clsMovieCollection Movies = new clsMovieCollection();
        Movies.ThisMovie.Find(MovieId);

        txtMovieId.Text = Movies.ThisMovie.MovieId.ToString();
        lblTitle.Text = Movies.ThisMovie.Title;
        lblRuntime.Text = Movies.ThisMovie.Runtime.ToString();
        lblReleaseDate.Text = Movies.ThisMovie.ReleaseDate.ToString();
        lblDescription.Text = Movies.ThisMovie.Description;
        lblGenre.Text = Movies.ThisMovie.Genre;
        lblRating.Text = Movies.ThisMovie.Rating.ToString();
        lblDirectors.Text = Movies.ThisMovie.Directors;
        lblWriters.Text = Movies.ThisMovie.Writers;
        lblStarActors.Text = Movies.ThisMovie.StarActors;
        imgCoverImage.ImageUrl = Movies.ThisMovie.CoverImage;
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}