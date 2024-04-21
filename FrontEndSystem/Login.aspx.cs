using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class Login :  System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string email = txtEmail.Text.Trim();
        string password = txtPassword.Text.Trim();

        using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"H:\\Project Database\\MovieMindsNetwork.mdf\";Integrated Security=True;Connect Timeout=30"))
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM tblRegistration WHERE username=@username AND email=@email AND password=@password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

            int v = (int)command.ExecuteScalar();

            connection.Close();

            if (v == 1)
            {
                Session["username"] = username;
                Session["email"] = email;

                Response.Redirect("HomePage.aspx");
            }
            else
            {
                lblError.Text = "Invalid username, email, or password.";
                lblError.Visible = true;
            }
        }

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registration.aspx");
    }
}