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
        clsShow AShow = new clsShow();
        AShow = (clsShow)Session["AShow"];

        Response.Write(AShow.ShowId);
        Response.Write(AShow.Title);
        Response.Write(AShow.Seasons);
        Response.Write(AShow.ReleaseDate);
        Response.Write(AShow.Description);
        Response.Write(AShow.Genre);
        Response.Write(AShow.Rating);
        Response.Write(AShow.Creators);
        Response.Write(AShow.StarActors);
        Response.Write(AShow.CoverImage);
    }
}