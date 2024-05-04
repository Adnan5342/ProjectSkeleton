using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MessageConfirmDelete : System.Web.UI.Page
{
    Int32 MessageId;

    protected void Page_Load(object sender, EventArgs e)
    {
        MessageId = Convert.ToInt32(Session["MessageId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsMessageCollection Messages = new clsMessageCollection();
        Messages.ThisMessage.Find(MessageId);
        Messages.Delete(MessageId);
        Response.Redirect("MessageList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("MessageList.aspx");
    }
}