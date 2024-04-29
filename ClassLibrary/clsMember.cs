using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsMember
    {
        private Int32 mMemberId;
        private string mUsername;
        private string mEmail;
        private string mPassword;

        public int MemberId
        {
            get { return mMemberId; }
            set { mMemberId = value; }
        }

        public string Username
        {
            get { return mUsername; }
            set { mUsername = value; }
        }

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public bool Find(int MemberId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MemberId", MemberId);
            DB.Execute("sproc_tblRegistration_FilterByMemberId");

            if (DB.Count == 1)
            {
                mMemberId = Convert.ToInt32(DB.DataTable.Rows[0]["MemberId"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string username, string email, string password)
        {
            String Error = "";

            if (username.Length < 5)
            {
                Error = Error + "The username must have a minimum of 5 characters. ";
            }

            if (username.Length > 15)
            {
                Error = Error + "The username must have less than 16 characters. ";
            }

            if (email.Length < 5)
            {
                Error = Error + "The email must have a minimum of 5 characters. ";
            }

            if (email.Length > 50)
            {
                Error = Error + "The email must have less than 51 characters. ";
            }

            if (password.Length < 5)
            {
                Error = Error + "The password must have a minimum of 5 characters. ";
            }

            if (password.Length > 15)
            {
                Error = Error + "The password must have less than 16 characters. ";
            }

            return Error;
        }

    }
}
