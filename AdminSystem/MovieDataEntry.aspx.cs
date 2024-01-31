using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 MovieId;

    protected void Page_Load(object sender, EventArgs e)
    {
        MovieId = Convert.ToInt32(Session["MovieId"]);
        if (IsPostBack == false)
        {
            if (MovieId != -1)
            {
                DisplayMovies();
            }
        }
    }

    void DisplayMovies()
    {
        clsMovieCollection MovieList = new clsMovieCollection();
        MovieList.ThisMovie.Find(MovieId);

        txtMovieId.Text = MovieList.ThisMovie.MovieId.ToString();
        txtTitle.Text = MovieList.ThisMovie.Title;
        txtRuntime.Text = MovieList.ThisMovie.Runtime.ToString();
        txtReleaseDate.Text = MovieList.ThisMovie.ReleaseDate.ToString();
        txtDescription.Text = MovieList.ThisMovie.Description;
        txtGenre.Text = MovieList.ThisMovie.Genre;
        txtRating.Text = MovieList.ThisMovie.Rating.ToString();
        txtDirectors.Text = MovieList.ThisMovie.Directors;
        txtWriters.Text = MovieList.ThisMovie.Writers;
        txtStarActors.Text = MovieList.ThisMovie.StarActors;
        txtCoverImage.Text = MovieList.ThisMovie.CoverImage;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsMovie AMovie = new clsMovie();

        //capture
        string Title = txtTitle.Text;
        string Runtime = txtRuntime.Text;
        string ReleaseDate = txtReleaseDate.Text;
        string Description = txtDescription.Text;
        string Genre = txtGenre.Text;
        double Rating;
        if (txtRating.Text.Length == 0)
        {
            Rating = 0;
        }
        else
        {
            Rating = 0;
        }
        string Directors = txtDirectors.Text;
        string Writers = txtWriters.Text;
        string StarActors = txtStarActors.Text;
        string CoverImage = txtCoverImage.Text;
        string Error = "";

        Error = AMovie.Valid(Title, Runtime, ReleaseDate, Description, Genre, Rating, Directors,
            Writers, StarActors);

        if (Error == "")
        {
            //capture
            AMovie.MovieId = MovieId;
            AMovie.Title = Title;
            AMovie.Runtime = TimeSpan.Parse(Runtime);
            AMovie.ReleaseDate = Convert.ToDateTime(ReleaseDate);
            AMovie.Description = Description;
            AMovie.Genre = Genre;
            AMovie.Rating = Rating; ;
            AMovie.Directors = Directors;
            AMovie.Writers = Writers;
            AMovie.StarActors = StarActors;
            AMovie.CoverImage = CoverImage;

            clsMovieCollection MovieList = new clsMovieCollection();

            if (MovieId == -1)
            {
                MovieList.ThisMovie = AMovie;
                MovieList.Add();
            }
            else
            {
                MovieList.ThisMovie.Find(MovieId);
                MovieList.ThisMovie = AMovie;
                MovieList.Update();
            }
            Response.Redirect("MovieList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsMovie AMovie = new clsMovie();
        Int32 MovieId;
        Boolean Found = false;
        MovieId = Convert.ToInt32(txtMovieId.Text);
        Found = AMovie.Find(MovieId);
        if (Found == true) 
        {
            //display in form
            txtMovieId.Text = AMovie.MovieId.ToString();
            txtTitle.Text = AMovie.Title;
            txtRuntime.Text = AMovie.Runtime.ToString();
            txtReleaseDate.Text = AMovie.ReleaseDate.ToString();
            txtDescription.Text = AMovie.Description;
            txtGenre.Text = AMovie.Genre;
            txtRating.Text = AMovie.Rating.ToString();
            txtDirectors.Text = AMovie.Directors;
            txtWriters.Text = AMovie.Writers;
            txtStarActors.Text = AMovie.StarActors;
            txtCoverImage.Text = AMovie.CoverImage;
        }
    }
}