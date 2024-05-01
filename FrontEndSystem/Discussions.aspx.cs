using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Discussions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            clsMessageCollection Messages = new clsMessageCollection();

            try
            {
                DisplayMessages(Messages);
            }
            catch (Exception ex)
            {
                lblErrorEx.Text = ex.Message;
            }
        }
    }

    void DisplayMessages(clsMessageCollection Messages)
    {
        Messages.ReportByMostRecent10();

        for (int i = 0; i < Messages.MessageList.Count && i < 7; i++)
        {
            switch (i + 1)
            {
                case 1:
                    lblMessageText1.Text = Messages.MessageList[i].Message;
                    break;
                case 2:
                    lblMessageText2.Text = Messages.MessageList[i].Message;
                    break;
                case 3:
                    lblMessageText3.Text = Messages.MessageList[i].Message;
                    break;
                case 4:
                    lblMessageText4.Text = Messages.MessageList[i].Message;
                    break;
                case 5:
                    lblMessageText5.Text = Messages.MessageList[i].Message;
                    break;
                case 6:
                    lblMessageText6.Text = Messages.MessageList[i].Message;
                    break;
                case 7:
                    lblMessageText7.Text = Messages.MessageList[i].Message;
                    break;
            }
        }
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void imgBtnProfile_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ProfileViewer.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("MessageEntry.aspx");
    }
}