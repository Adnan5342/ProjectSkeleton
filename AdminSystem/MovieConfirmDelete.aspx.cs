using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 MovieId;

    protected void Page_Load(object sender, EventArgs e)
    {
        MovieId = Convert.ToInt32(Session["MovieId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsMovieCollection Movies = new clsMovieCollection();
        Movies.ThisMovie.Find(MovieId);
        Movies.Delete(MovieId); // pass MovieId as an argument
        Response.Redirect("MovieList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieList.aspx");
    }
}