using System;
using System.Collections.Generic;
using System.Linq;
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
        AShow.Title = txtTitle.Text;
        AShow.Seasons = Convert.ToInt32(txtSeasons.Text);
        AShow.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
        AShow.Description = txtDescription.Text;
        AShow.Genre = txtGenre.Text;
        AShow.Rating = Convert.ToDouble(txtRating.Text);
        AShow.Creators = txtCreators.Text;
        AShow.StarActors = txtStarActors.Text;
        AShow.CoverImage = txtCoverImage.Text;                                                                                                                                          
        Session["AShow"] = AShow;
        Response.Redirect("ShowViewer.aspx");
    }
}