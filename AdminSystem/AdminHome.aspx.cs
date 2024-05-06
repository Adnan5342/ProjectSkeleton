using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] != null && Session["Email"] != null && IsPostBack == false)
        {
            DisplayRecordCount();
        }
    }

    void DisplayRecordCount()
    {
        clsMovieCollection Movies = new clsMovieCollection();
        lblMovieCount.Text = lblMovieCount.Text + Movies.Count.ToString();

        clsShowCollection Shows = new clsShowCollection();
        lblShowCount.Text = lblShowCount.Text + Shows.Count.ToString();

        clsMemberCollection Users = new clsMemberCollection();
        lblUserCount.Text = lblUserCount.Text + Users.Count.ToString();

        clsMovieReviewCollection MovieReviews = new clsMovieReviewCollection();
        lblMReviewCount.Text = lblMReviewCount.Text + MovieReviews.Count.ToString();

        clsShowReviewCollection ShowReviews = new clsShowReviewCollection();
        lblSReviewCount.Text = lblSReviewCount.Text + ShowReviews.Count.ToString();

        clsMessageCollection Messages = new clsMessageCollection();
        lblMessageCount.Text = lblMessageCount.Text + Messages.Count.ToString();
    }

    protected void btnMovies_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieList.aspx");
    }

    protected void btnShows_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowList.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }

    protected void btnMembers_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberList.aspx");
    }

    protected void btnMovieReviews_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieReviewList.aspx");
    }

    protected void btnShowReviews_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowReviewList.aspx");
    }

    protected void btnMessages_Click(object sender, EventArgs e)
    {
        Response.Redirect("MessageList.aspx");
    }

    protected void lnkBtnSignOut_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("AdminLogin.aspx");
    }
}