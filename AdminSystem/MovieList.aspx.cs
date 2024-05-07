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
            //update list
            DisplayMovies();
        }
    }

    void DisplayMovies()
    {
        clsMovieCollection Movies = new clsMovieCollection();
        lstMovieList.DataSource = Movies.MovieList;
        lstMovieList.DataValueField = "MovieId";
        lstMovieList.DataTextField = "Title";
        lstMovieList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["MovieId"] = -1;
        Response.Redirect("MovieDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 MovieId;

        if (lstMovieList.SelectedIndex != -1)
        {
            MovieId = Convert.ToInt32(lstMovieList.SelectedValue);
            Session["MovieId"] = MovieId;
            Response.Redirect("MovieDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit: ";
            lblError.ForeColor = System.Drawing.Color.Red;
        }                
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 MovieId;
        if (lstMovieList.SelectedIndex != -1)
        {
            MovieId = Convert.ToInt32(lstMovieList.SelectedValue);
            Session["MovieId"] = MovieId;
            Response.Redirect("MovieConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete: ";
            lblError.ForeColor = System.Drawing.Color.Red;
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsMovieCollection MovieCollection = new clsMovieCollection();
        MovieCollection.ReportByTitle(txtFilterByTitle.Text);
        lstMovieList.DataSource = MovieCollection.MovieList;
        lstMovieList.DataValueField = "MovieId";
        lstMovieList.DataTextField = "Title";
        lstMovieList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsMovieCollection MovieCollection = new clsMovieCollection();
        MovieCollection.ReportByTitle("");
        txtFilterByTitle.Text = "";
        lstMovieList.DataSource = MovieCollection.MovieList;
        lstMovieList.DataValueField = "MovieId";
        lstMovieList.DataTextField = "Title";
        lstMovieList.DataBind();
    }

    protected void lnkBtnShows_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowList.aspx");
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AdminHome.aspx");
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        Int32 MovieId;

        if (lstMovieList.SelectedIndex != -1)
        {
            MovieId = Convert.ToInt32(lstMovieList.SelectedValue);
            Session["MovieId"] = MovieId;
            Response.Redirect("MovieViewer.aspx");
        }
        else
        {
            lblError.Text = "Please select a movie to view. ";
            lblError.ForeColor = System.Drawing.Color.Red;
        }
    }

    protected void lnkBtnMovieReviews_Click(object sender, EventArgs e)
    {
        Response.Redirect("MovieReviewList.aspx");
    }

    protected void lnkBtnShowReviews_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowReviewList.aspx");
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