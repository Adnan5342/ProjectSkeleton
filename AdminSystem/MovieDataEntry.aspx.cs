using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
            Rating = double.Parse(txtRating.Text);
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
            AMovie.MovieId = Convert.ToInt32(txtMovieId.Text);
            AMovie.Title = txtTitle.Text;
            AMovie.Runtime = TimeSpan.Parse(txtRuntime.Text);
            AMovie.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
            AMovie.Description = txtDescription.Text;
            AMovie.Genre = txtGenre.Text;
            AMovie.Rating = Convert.ToDouble(txtRating.Text);
            AMovie.Directors = txtDirectors.Text;
            AMovie.Writers = txtWriters.Text;
            AMovie.StarActors = txtStarActors.Text;
            AMovie.CoverImage = txtCoverImage.Text;
            //store
            Session["AMovie"] = AMovie;
            //navigate to the viewer page
            Response.Write("MovieViewer.aspx");

            //display error
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

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