using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserViewJurassicPark : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void imgBtnProfile_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("UserLogin.aspx");
    }

    protected void imgbtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("UserHomepage.aspx");
    }

    protected void txtStarActors_TextChanged(object sender, EventArgs e)
    {

    }
}