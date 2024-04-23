using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class TopShowsAndMovies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void DisplayTopMovies()
    {

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