using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayMovies();
    }

    void DisplayMovies()
    {
        clsMovieCollection Movies = new clsMovieCollection();
        lstMovies.DataSource = Movies.MovieList;
        lstMovies.DataValueField = "MovieId";
        lstMovies.DataTextField = "Title";
        lstMovies.DataBind();
    }

    protected void imgBtnProfile_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ProfileViewer.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}