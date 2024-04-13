using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Security;
using System.Diagnostics;

namespace Registration
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"H:\\Project Database\\MovieMindsNetwork.mdf\";Integrated Security=True;Connect Timeout=30");

        private void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRemember.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && email.Text != "" && password.Text != "")
            {
                string query = "SELECT COUNT(*) FROM tblRegistration WHERE username=@username AND email=@email AND password=@password";

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                command.Parameters.AddWithValue("@password", password.Text);

                try
                {
                    int v = (int)command.ExecuteScalar();
                    connection.Close();

                    if (v != 1)
                    {
                        MessageBox.Show("Error: Invalid username, email, or password", "Error!");
                    }
                    else
                    {
                        MessageBox.Show("Welcome to your profile!");

                        Process.Start("cmd", $"/c start http://localhost:53096/HomePage.aspx");

                        username.Text = "";
                        email.Text = "";
                        password.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error!");
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill in the blanks!");
            }
        }


        private void lnkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
