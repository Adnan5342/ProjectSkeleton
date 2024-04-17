using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Registration;

public partial class ProfileViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void DisplayProfile()
    {
        string username = Session["username"] as string;
        string email = Session["email"] as string;

        if (!string.IsNullOrEmpty(username))
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\Project Database\\MovieMindsNetwork.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                string query = "SELECT * FROM tblRegistration WHERE username = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtUsername.Text = reader["username"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                }
                reader.Close();
            }
        }
        else if (!string.IsNullOrEmpty(email))
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\Project Database\\MovieMindsNetwork.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                string query = "SELECT * FROM tblRegistration WHERE email = @email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtUsername.Text = reader["username"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                }
                reader.Close();
            }
        }
    }


    protected void imgBtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        DisplayProfile();
    }

    protected void btnSignOut_Click(object sender, EventArgs e)
    {
        
    }
}