using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowReviewList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayShowReviews();
        }
    }

    void DisplayShowReviews()
    {
        clsShowReviewCollection ShowReviews = new clsShowReviewCollection();

        lstShowReviewList.DataSource = ShowReviews.ShowReviewList;
        lstShowReviewList.DataValueField = "ShowReviewId";
        lstShowReviewList.DataTextField = "Username";
        lstShowReviewList.DataBind();

        foreach (ListItem item in lstShowReviewList.Items)
        {
            item.Text += " - \"" + ShowReviews.ShowReviewList.Find(x => x.ShowReviewId == Convert.ToInt32(item.Value)).Comment + "\"";
        }
    }

    protected void lnkBtnMovies_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieReviewList.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }
}