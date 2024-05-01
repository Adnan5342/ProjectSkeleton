using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MessageEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MemberId"] != null && Session["Username"] != null && Session["Email"] != null)
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
        txtMemberId.Text = Session["MemberId"].ToString();
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsMessage AMessage = new clsMessage();

        Int32 MemberId = Convert.ToInt32(txtMemberId.Text);
        string Message = txtMessage.Text;
        string DatePosted = txtDatePosted.Text;

        string Error = "";

        Error = AMessage.Valid(Message, DatePosted);

        if (Error == "")
        {
            AMessage.MemberId = MemberId;
            AMessage.Message = Message;
            AMessage.DatePosted = Convert.ToDateTime(DatePosted);

            clsMessageCollection MessageList = new clsMessageCollection();

            MessageList.ThisMessage = AMessage;
            MessageList.Add();

            Response.Redirect("Discussions.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Discussions.aspx");
    }
}