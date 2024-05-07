using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class MemberList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayMembers();
        }
    }

    void DisplayMembers()
    {
        clsMemberCollection Members = new clsMemberCollection();
        lstMemberList.DataSource = Members.MemberList;
        lstMemberList.DataValueField = "MemberId";
        lstMemberList.DataTextField = "Username";
        lstMemberList.DataBind();
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 MemberId;
        if (lstMemberList.SelectedIndex != -1)
        {
            MemberId = Convert.ToInt32(lstMemberList.SelectedValue);
            Session["MemberId"] = MemberId;
            Response.Redirect("MemberConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a user to delete. ";
            lblError.ForeColor = System.Drawing.Color.Red;
        }
    }

    protected void lnkBtnMessages_Click(object sender, EventArgs e)
    {
        Response.Redirect("MessageList.aspx");
    }

    protected void lnkBtnMovies_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieList.aspx");
    }

    protected void lnkBtnShows_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowList.aspx");
    }

    protected void lnkBtnMovieReviews_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieReviewList.aspx");
    }

    protected void lnkBtnShowReviews_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowReviewList.aspx");
    }
}