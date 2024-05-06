using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    Int32 ShowId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] != null && Session["Email"] != null && Session["ShowId"] != null)
        {
            ShowId = Convert.ToInt32(Session["ShowId"]);
            if (ShowId != -1)
            {
                DisplayShow();
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    void DisplayShow()
    {
        clsShowCollection Shows = new clsShowCollection();
        Shows.ThisShow.Find(ShowId);

        lblTitleText.Text = Shows.ThisShow.Title;
        lblSeasonsText.Text = Shows.ThisShow.Seasons.ToString();
        lblReleaseDateText.Text = Shows.ThisShow.ReleaseDate.ToShortDateString();
        lblDescriptionText.Text = Shows.ThisShow.Description;
        lblCreatorsText.Text = Shows.ThisShow.Creators;
        lblStarActorsText.Text = Shows.ThisShow.StarActors;
        lblRatingText.Text = Shows.ThisShow.Rating.ToString();
        lblGenreText.Text = Shows.ThisShow.Genre;
        imgCoverImage.ImageUrl = Shows.ThisShow.CoverImage;
    }

    protected void btnShowList_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowList.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }
}