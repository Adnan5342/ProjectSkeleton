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

    /*protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ShowReviewId;
        if (lstShowReviewList.SelectedIndex != 1)
        {
            ShowReviewId = Convert.ToInt32(lstShowReviewList.SelectedValue);
            Session["ShowReviewId"] = ShowReviewId;
            Response.Redirect("ShowReviewConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a review to delete. ";
        }
    }*/

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (lstShowReviewList.SelectedIndex == -1)
        {
            lblError.Text = "Please select a review to delete. ";
            return;
        }

        int showReviewId;
        if (!int.TryParse(lstShowReviewList.SelectedValue, out showReviewId))
        {
            lblError.Text = "Invalid review ID. Please select a valid review to delete. ";
            return;
        }

        Session["ShowReviewId"] = showReviewId;
        Response.Redirect("ShowReviewConfirmDelete.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }
}