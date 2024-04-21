using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MovieReviewEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsMovieReview AMovieReview = new clsMovieReview();

        AMovieReview.DatePosted = Convert.ToDateTime(txtDatePosted.Text);
        AMovieReview.Rating = Convert.ToDouble(txtRating.Text);
        AMovieReview.Comment = txtComment.Text;

        Session["AMovieReview"] = AMovieReview;

        Response.Redirect("MovieReviewViewer.aspx");
    }
}