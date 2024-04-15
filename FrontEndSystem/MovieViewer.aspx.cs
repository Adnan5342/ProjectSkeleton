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
        if (!IsPostBack)
        {
            MovieId = Convert.ToInt32(Session["MovieId"]);
            if (MovieId != -1)
            {
                DisplayMovies();
            }
        }
    }

    void DisplayMovies()
    {
        clsMovieCollection Movies = new clsMovieCollection();
        Movies.ThisMovie.Find(MovieId);

        lblTitle.Text = Movies.ThisMovie.Title;
    }
}