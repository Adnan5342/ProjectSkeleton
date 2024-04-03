using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsShow AShow = new clsShow();

        string Title = txtTitle.Text;
        int Seasons;
        if (txtSeasons.Text.Length == 0)
        {
            Seasons = 0;
        }
        else
        {
            Seasons = 0;
        }
        string ReleaseDate = txtReleaseDate.Text;
        string Description = txtDescription.Text;
        string Genre = txtGenre.Text;
        double Rating;
        if (txtRating.Text.Length == 0)
        {
            Rating = 0;
        }
        else
        {
            Rating = 0;
        }
        string Creators = txtCreators.Text;
        string StarActors = txtStarActors.Text;
        string CoverImage = txtCoverImage.Text;

        string Error = "";
        Error = AShow.Valid(Title, Description, Genre, Creators, StarActors, CoverImage, ReleaseDate, Rating);

        if (Error == "")
        {
            //AShow.ShowId = ShowId;
            AShow.Title = Title;
            AShow.Seasons = Convert.ToInt32(Seasons);
            AShow.ReleaseDate = Convert.ToDateTime(ReleaseDate);
            AShow.Description = Description;
            AShow.Genre = Genre;
            AShow.Rating = Convert.ToDouble(Rating);
            AShow.Creators = Creators;
            AShow.StarActors = StarActors;
            AShow.CoverImage = CoverImage;
            Session["AShow"] = AShow;
            Response.Write("ShowViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsShow AShow = new clsShow();
        Int32 ShowId;
        Boolean Found = false;
        ShowId = Convert.ToInt32(txtShowId.Text);
        Found = AShow.Find(ShowId);
        if (Found == true)
        {
            txtTitle.Text = AShow.Title;
            txtSeasons.Text = AShow.Seasons.ToString();
            txtReleaseDate.Text = AShow.ReleaseDate.ToString();
            txtDescription.Text = AShow.Description;
            txtGenre.Text = AShow.Genre;
            txtRating.Text = AShow.Rating.ToString();
            txtCreators.Text = AShow.Creators;
            txtStarActors.Text = AShow.StarActors;
            txtCoverImage.Text = AShow.CoverImage;
        }
    }
}