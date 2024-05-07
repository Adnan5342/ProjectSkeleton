using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MessageList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayMessages();
        }
    }

    void DisplayMessages()
    {
        clsMessageCollection Messages = new clsMessageCollection();

        lstMessageList.DataSource = Messages.MessageList;
        lstMessageList.DataValueField = "MessageId";
        lstMessageList.DataTextField = "Username";
        lstMessageList.DataBind();

        foreach (ListItem item in lstMessageList.Items )
        {
            item.Text += " - \"" + Messages.MessageList.Find(x => x.MessageId == Convert.ToInt32(item.Value)).Message + "\"";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (lstMessageList.SelectedIndex == -1)
        {
            lblError.Text = "Please select a message to delete. ";
            lblError.ForeColor = System.Drawing.Color.Red;
            return;
        }

        int messageId;
        if (!int.TryParse(lstMessageList.SelectedValue, out messageId))
        {
            lblError.Text = "Invalid message ID. ";
            lblError.ForeColor = System.Drawing.Color.Red;
            return;
        }

        Session["MessageId"] = messageId;
        Response.Redirect("MessageConfirmDelete.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }

    protected void lnkBtnMembers_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberList.aspx");
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