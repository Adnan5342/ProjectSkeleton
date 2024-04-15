using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Registration;
using ClassLibrary;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayMovies();
        DisplayShows();
    }

    void DisplayMovies()
    {
        clsMovieCollection Movies = new clsMovieCollection();
        lstMovieList.DataSource = Movies.MovieList;
        lstMovieList.DataValueField = "MovieId";
        lstMovieList.DataTextField = "Title";
        lstMovieList.DataBind();
    }

    void DisplayShows()
    {
        clsShowCollection Shows = new clsShowCollection();
        lstShows.DataSource = Shows.ShowList;
        lstShows.DataValueField = "ShowId";
        lstShows.DataTextField = "Title";
        lstShows.DataBind();
    }

    protected void imgBtnProfile_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ProfileViewer.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void btnViewMovie_Click(object sender, EventArgs e)
    {
        Int32 MovieId;

        if (lstMovieList.SelectedIndex == -1)
        {
            MovieId = Convert.ToInt32(lstMovieList.SelectedValue);
            Session["MovieId"] = MovieId;
            Response.Redirect("MovieViewer.aspx");
        }
        else 
        {
            lblMovieError.Text = "Please select a movie to view.";
        }
    }

    protected void btnViewShow_Click(object sender, EventArgs e)
    {
        Int32 ShowId;

        if (lstShows.SelectedIndex != -1)
        {
            ShowId = Convert.ToInt32(lstShows.SelectedValue);
            Session["ShowId"] = ShowId;
            Response.Redirect("ShowViewer.aspx");
        }
        else
        {
            lblShowError.Text = "Please select a show to view.";
        }
    }
}