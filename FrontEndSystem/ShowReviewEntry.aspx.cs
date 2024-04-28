using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowReviewEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["memberId"] != null && Session["username"] != null && Session["email"] != null && Session["ShowId"] != null)
        {
            DisplaySessionIDs();
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    void DisplaySessionIDs()
    {
        txtShowId.Text = Session["ShowId"].ToString();
        txtMemberId.Text = Session["memberId"].ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsShowReview AShowReview = new clsShowReview();

        Int32 ShowId = Convert.ToInt32(txtShowId.Text);
        Int32 MemberId = Convert.ToInt32(txtMemberId.Text);
        string Rating = txtRating.Text;
        string Comment = txtComment.Text;
        string DatePosted = txtDatePosted.Text;

        string Error = "";

        Error = AShowReview.Valid(Rating, Comment, DatePosted);

        if (Error == "")
        {
            AShowReview.ShowId = ShowId;
            AShowReview.MemberId = MemberId;
            AShowReview.Rating = Convert.ToDouble(Rating);
            AShowReview.Comment = Comment;
            AShowReview.DatePosted = Convert.ToDateTime(DatePosted);

            clsShowReviewCollection ShowReviewList = new clsShowReviewCollection();

            ShowReviewList.ThisShowReview = AShowReview;
            ShowReviewList.Add();

            Response.Redirect("ShowViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowViewer.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}