using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class MovieReviewViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsMovieReview AMovieReview = new clsMovieReview();
        AMovieReview = (clsMovieReview)Session["AMovieReview"];
        Response.Write(AMovieReview.Comment);
    }
}