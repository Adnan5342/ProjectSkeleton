using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsMovie AMovie = new clsMovie();
        //retrieve data
        AMovie = (clsMovie)Session["AMovie"];
        //display
        Response.Write(AMovie.MovieId);
        Response.Write(AMovie.Title);
        Response.Write(AMovie.Runtime);
        Response.Write(AMovie.ReleaseDate);
        Response.Write(AMovie.Description);
        Response.Write(AMovie.Genre);
        Response.Write(AMovie.Rating);
        Response.Write(AMovie.Directors);
        Response.Write(AMovie.Writers);
        Response.Write(AMovie.StarActors);
    }
}