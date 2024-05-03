using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MovieReviewList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayMovieReviews();
        }
    }

    void DisplayMovieReviews()
    {
        clsMovieReviewCollection MovieReviews = new clsMovieReviewCollection();

        lstMovieReviewList.DataSource = MovieReviews.MovieReviewList;
        lstMovieReviewList.DataValueField = "MovieReviewId";
        lstMovieReviewList.DataTextField = "Username";
        lstMovieReviewList.DataBind();

        foreach (ListItem item in lstMovieReviewList.Items)
        {
            item.Text += " - \"" + MovieReviews.MovieReviewList.Find(x => x.MovieReviewId == Convert.ToInt32(item.Value)).Comment + "\"";
        }
    }

    protected void lnkBtnMovies_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowReviewList.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }
}