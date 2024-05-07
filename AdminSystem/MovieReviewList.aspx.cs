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

    protected void lnkBtnShowReviews_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowReviewList.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }

    /*protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 MovieReviewId;
        if (lstMovieReviewList.SelectedIndex != 1)
        {
            MovieReviewId = Convert.ToInt32(lstMovieReviewList.SelectedValue);
            Session["MovieReviewId"] = MovieReviewId;
            Response.Redirect("MovieReviewConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a review to delete. ";
        }
    }*/

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (lstMovieReviewList.SelectedIndex == -1)
        {
            lblError.Text = "Please select a review to delete. ";
            lblError.ForeColor = System.Drawing.Color.Red;
            return;
        }

        int movieReviewId;
        if (!int.TryParse(lstMovieReviewList.SelectedValue, out movieReviewId))
        {
            lblError.Text = "Invalid review ID. ";
            lblError.ForeColor = System.Drawing.Color.Red;
            return;
        }

        Session["MovieReviewId"] = movieReviewId;
        Response.Redirect("MovieReviewConfirmDelete.aspx");
    }

    protected void lnkBtnMovies_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieList.aspx");
    }

    protected void lnkBtnShows_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowList.aspx");
    }

    protected void lnkBtnUsers_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberList.aspx");
    }

    protected void lnkBtnMessages_Click(object sender, EventArgs e)
    {
        Response.Redirect("MessageList.aspx");
    }
}