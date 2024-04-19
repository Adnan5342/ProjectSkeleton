using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class ShowViewer : System.Web.UI.Page
{
    Int32 ShowId;

    protected void Page_Load(object sender, EventArgs e)
    {
        ShowId = Convert.ToInt32(Session["ShowId"]);
        if (ShowId != -1)
        {
            DisplayShows();
        }
    }

    void DisplayShows()
    {
        clsShowCollection Shows = new clsShowCollection();
        Shows.ThisShow.Find(ShowId);

        lblTitleText.Text = Shows.ThisShow.Title;
        lblSeasonsText.Text = Shows.ThisShow.Seasons.ToString();
        lblReleaseDateText.Text = Shows.ThisShow.ReleaseDate.ToString();
        lblDescriptionText.Text = Shows.ThisShow.Description;
        lblCreatorsText.Text = Shows.ThisShow.Creators;
        lblStarActorsText.Text = Shows.ThisShow.StarActors;
        lblRatingText.Text = Shows.ThisShow.Rating.ToString();
        lblGenreText.Text = Shows.ThisShow.Genre;
    }


    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void imgBtnProfile_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ProfileViewer.aspx");
    }
}