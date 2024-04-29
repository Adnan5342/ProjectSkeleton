using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MemberConfirmDelete : System.Web.UI.Page
{
    Int32 MemberId;

    protected void Page_Load(object sender, EventArgs e)
    {
        MemberId = Convert.ToInt32(Session["MemberId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsMemberCollection Members = new clsMemberCollection();
        Members.ThisMember.Find(MemberId);
        Members.Delete(MemberId);
        Response.Redirect("MemberList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberList.aspx");
    }
}