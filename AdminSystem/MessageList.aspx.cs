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
            return;
        }

        int messageId;
        if (!int.TryParse(lstMessageList.SelectedValue, out messageId))
        {
            lblError.Text = "Invalid message ID. ";
            return;
        }

        Session["MessageId"] = messageId;
        Response.Redirect("MessageConfirmDelete.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }
}