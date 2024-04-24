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
            try
            {
                DisplayTopMovies(Movies);
            }
            catch (Exception ex)
            {
                // Display an error message or take other appropriate action
                // For example:
                lblError.Text = ex.Message;
            }
        }
    }

    void DisplayTopMovies(clsMovieCollection Movies)
    {
        Movies.ReportByTop5();
        imgMovieImage1.ImageUrl = Movies.MovieList[0].CoverImage;
        imgMovieImage2.ImageUrl = Movies.MovieList[1].CoverImage;
        imgMovieImage3.ImageUrl = Movies.MovieList[2].CoverImage;
        imgMovieImage4.ImageUrl = Movies.MovieList[3].CoverImage;
        imgMovieImage5.ImageUrl = Movies.MovieList[4].CoverImage;
    }

    void DisplayTopShows()
    {

    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }

    protected void imgBtnProfile_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ProfileViewer.aspx");
    }
}