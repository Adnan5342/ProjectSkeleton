using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"H:\\Project Database\\MovieMindsNetwork.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtConPassword.Text != "")
                {
                    if (txtPassword.Text == txtConPassword.Text)
                    {
                        int v = check(txtEmail.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into tblRegistration values(@username" + "@email,@password)", connection);
                            command.Parameters.AddWithValue("@username", txtUsername.Text);
                            command.Parameters.AddWithValue("@email", txtEmail.Text);
                            command.Parameters.AddWithValue("@password", txtPassword.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Account registration successful!");
                            txtUsername.Text = "";
                            txtEmail.Text = "";
                            txtPassword.Text = "";
                            txtConPassword.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("You are already registered!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match.");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the blanks!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int check(string txtEmail)
        {
            connection.Open();
            string query = "select count(*) from tblRegistration where email='" + txtEmail + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if(chkRememberMe.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
