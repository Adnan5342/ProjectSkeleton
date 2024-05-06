using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayShows();
        }
    }

    void DisplayShows()
    {
        clsShowCollection Shows = new clsShowCollection();
        lstShowList.DataSource = Shows.ShowList;
        lstShowList.DataValueField = "ShowId";
        lstShowList.DataTextField = "Title";
        lstShowList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ShowId"] = -1;
        Response.Redirect("ShowDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ShowId;

        if (lstShowList.SelectedIndex != -1)
        {
            ShowId = Convert.ToInt32(lstShowList.SelectedValue);
            Session["ShowId"] = ShowId;
            Response.Redirect("ShowDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit: ";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ShowId;

        if (lstShowList.SelectedIndex != -1)
        {
            ShowId = Convert.ToInt32(lstShowList.SelectedValue);
            Session["ShowId"] = ShowId;
            Response.Redirect("ShowConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete: ";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsShowCollection Shows = new clsShowCollection();
        Shows.ReportByTitle(txtFilterByTitle.Text);
        lstShowList.DataSource = Shows.ShowList;
        lstShowList.DataValueField = "ShowId";
        lstShowList.DataTextField = "Title";
        lstShowList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsShowCollection Shows = new clsShowCollection();
        Shows.ReportByTitle("");
        txtFilterByTitle.Text = "";
        lstShowList.DataSource = Shows.ShowList;
        lstShowList.DataValueField = "ShowId";
        lstShowList.DataTextField= "Title";
        lstShowList.DataBind();
    }

    protected void btnShowPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieList.aspx");
    }

    protected void lnkBtnMovies_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieList.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        Int32 ShowId;

        if (lstShowList.SelectedIndex != -1)
        {
            ShowId = Convert.ToInt32(lstShowList.SelectedValue);
            Session["ShowId"] = ShowId;
            Response.Redirect("ShowViewer.aspx");
        }
        else
        {
            lblError.Text = "Please select a show to view. ";
            lblError.ForeColor = System.Drawing.Color.Red;
        }
    }

    protected void lnkBtnShowReviews_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowReviewList.aspx");
    }

    protected void lnkBtnMovieReviewList_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieReviewList.aspx");
    }

    protected void lnkBtnUsers_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberList.aspx");
    }

    protected void lnkBtnMessages_Click(object sender, EventArgs e)
    {
        Response.Redirect("MessageList.aspx");
    }
}