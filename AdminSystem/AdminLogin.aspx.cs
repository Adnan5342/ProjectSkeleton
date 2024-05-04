using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Visible = true;
    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        string Email = txtEmail.Text.Trim();
        string Password = txtPassword.Text.Trim();

        using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"H:\\Project Database\\MovieMindsNetwork.mdf\";Integrated Security=True;Connect Timeout=30"))
        {
            connection.Open();

            string query = "SELECT AdminId FROM tblAdmin WHERE Email=@Email AND Password=@Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);

            object result = command.ExecuteScalar();
            if (result != null)
            {
                int AdminId = (int)result;

                Session["Email"] = Email;
                Session["AdminId"] = AdminId;

                Response.Redirect("AdminHome.aspx");
            }
            else
            {
                lblError.Text = "Invalid email or password.";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }
    }

    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        lblError.Text = "You must sign in to access the admin system.";
        lblError.ForeColor = System.Drawing.Color.Red;
    }
}