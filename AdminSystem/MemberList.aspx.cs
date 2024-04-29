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
        lblError.Text = "Has not yet been implemented. ";
    }
}