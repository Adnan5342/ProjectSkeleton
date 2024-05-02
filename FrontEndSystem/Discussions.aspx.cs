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
                DisplayUsers(Messages);
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

    void DisplayUsers(clsMessageCollection Messages)
    {
        Messages.ReportByMostRecent10();

        for (int i = 0; i < Messages.MessageList.Count && i < 7; i++)
        {
            switch (i + 1)
            {
                case 1:
                    lblUserId1.Text = lblUserId1.Text + Messages.MessageList[i].MemberId.ToString();
                    break;
                case 2:
                    lblUserId2.Text = lblUserId2.Text + Messages.MessageList[i].MemberId.ToString();
                    break;
                case 3:
                    lblUserId3.Text = lblUserId3.Text + Messages.MessageList[i].MemberId.ToString();
                    break;
                case 4:
                    lblUserId4.Text = lblUserId4.Text + Messages.MessageList[i].MemberId.ToString();
                    break;
                case 5:
                    lblUserId5.Text = lblUserId5.Text + Messages.MessageList[i].MemberId.ToString();
                    break;
                case 6:
                    lblUserId6.Text = lblUserId6.Text + Messages.MessageList[i].MemberId.ToString();
                    break;
                case 7:
                    lblUserId7.Text = lblUserId7.Text + Messages.MessageList[i].MemberId.ToString();
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