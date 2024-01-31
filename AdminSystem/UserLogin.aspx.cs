using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Front_end_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void imgbtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("UserHomepage.aspx");
    }
}