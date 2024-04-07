using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 ShowId;

    protected void Page_Load(object sender, EventArgs e)
    {
        ShowId = Convert.ToInt32(Session["ShowId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsShowCollection Shows = new clsShowCollection();
        Shows.ThisShow.Find(ShowId);
        Shows.Delete();
        Response.Redirect("ShowList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowList.aspx");
    }
}