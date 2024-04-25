using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class TopShowsAndMovies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            clsMovieCollection Movies = new clsMovieCollection();
            clsShowCollection Shows = new clsShowCollection();
            try
            {
                DisplayTopMovies(Movies);
                DisplayTopShows(Shows);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }

    void DisplayTopMovies(clsMovieCollection Movies)
    {
        Movies.ReportByTop5();
        imgBtnMovieImage1.ImageUrl = Movies.MovieList[0].CoverImage;
        imgBtnMovieImage2.ImageUrl = Movies.MovieList[1].CoverImage;
        imgBtnMovieImage3.ImageUrl = Movies.MovieList[2].CoverImage;
        imgBtnMovieImage4.ImageUrl = Movies.MovieList[3].CoverImage;
        imgBtnMovieImage5.ImageUrl = Movies.MovieList[4].CoverImage;
    }

    void DisplayTopShows(clsShowCollection Shows)
    {
        Shows.ReportByTop5();
        imgBtnShowImage1.ImageUrl = Shows.ShowList[0].CoverImage;
        imgBtnShowImage2.ImageUrl = Shows.ShowList[1].CoverImage;
        imgBtnShowImage3.ImageUrl = Shows.ShowList[2].CoverImage;
        imgBtnShowImage4.ImageUrl = Shows.ShowList[3].CoverImage;
        imgBtnShowImage5.ImageUrl = Shows.ShowList[4].CoverImage;
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }

    protected void imgBtnProfile_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ProfileViewer.aspx");
    }

    protected void imgBtnMovieImage1_Click(object sender, ImageClickEventArgs e)
    {
        //Redirect to MovieViewer and set Sessionn["MovieId"] to the movie ID of the selected movie.
        clsMovieCollection Movies = new clsMovieCollection();
        Movies.ReportByTop5();
        Int32 MovieId = Movies.MovieList[0].MovieId;
        Session["MovieId"] = MovieId;

        Response.Redirect("MovieViewer.aspx");
    }

    protected void imgBtnMovieImage2_Click(object sender, ImageClickEventArgs e)
    {
        clsMovieCollection Movies = new clsMovieCollection();
        Movies.ReportByTop5();
        Int32 MovieId = Movies.MovieList[1].MovieId;
        Session["MovieId"] = MovieId;

        Response.Redirect("MovieViewer.aspx");
    }

    protected void imgBtnMovieImage3_Click(object sender, ImageClickEventArgs e)
    {
        clsMovieCollection Movies = new clsMovieCollection();
        Movies.ReportByTop5();
        Int32 MovieId = Movies.MovieList[2].MovieId;
        Session["MovieId"] = MovieId;

        Response.Redirect("MovieViewer.aspx");
    }

    protected void imgBtnMovieImage4_Click(object sender, ImageClickEventArgs e)
    {
        clsMovieCollection Movies = new clsMovieCollection();
        Movies.ReportByTop5();
        Int32 MovieId = Movies.MovieList[3].MovieId;
        Session["MovieId"] = MovieId;

        Response.Redirect("MovieViewer.aspx");
    }

    protected void imgBtnMovieImage5_Click(object sender, ImageClickEventArgs e)
    {
        clsMovieCollection Movies = new clsMovieCollection();
        Movies.ReportByTop5();
        Int32 MovieId = Movies.MovieList[4].MovieId;
        Session["MovieId"] = MovieId;

        Response.Redirect("MovieViewer.aspx");
    }

    protected void imgBtnShowImage1_Click(object sender, ImageClickEventArgs e)
    {
        clsShowCollection Shows = new clsShowCollection();
        Shows.ReportByTop5();
        Int32 ShowId = Shows.ShowList[0].ShowId;
        Session["ShowId"] = ShowId;

        Response.Redirect("ShowViewer.aspx");
    }

    protected void imgBtnShowImage2_Click(object sender, ImageClickEventArgs e)
    {
        clsShowCollection Shows = new clsShowCollection();
        Shows.ReportByTop5();
        Int32 ShowId = Shows.ShowList[1].ShowId;
        Session["ShowId"] = ShowId;

        Response.Redirect("ShowViewer.aspx");
    }

    protected void imgBtnShowImage3_Click(object sender, ImageClickEventArgs e)
    {
        clsShowCollection Shows = new clsShowCollection();
        Shows.ReportByTop5();
        Int32 ShowId = Shows.ShowList[2].ShowId;
        Session["ShowId"] = ShowId;

        Response.Redirect("ShowViewer.aspx");
    }

    protected void imgBtnShowImage4_Click(object sender, ImageClickEventArgs e)
    {
        clsShowCollection Shows = new clsShowCollection();
        Shows.ReportByTop5();
        Int32 ShowId = Shows.ShowList[3].ShowId;
        Session["ShowId"] = ShowId;

        Response.Redirect("ShowViewer.aspx");
    }

    protected void imgBtnShowImage5_Click(object sender, ImageClickEventArgs e)
    {
        clsShowCollection Shows = new clsShowCollection();
        Shows.ReportByTop5();
        Int32 ShowId = Shows.ShowList[4].ShowId;
        Session["ShowId"] = ShowId;

        Response.Redirect("ShowViewer.aspx");
    }
}