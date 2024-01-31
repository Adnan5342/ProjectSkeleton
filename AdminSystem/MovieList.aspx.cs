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
}