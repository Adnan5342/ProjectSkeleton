using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsMessage
    {
        private Int32 mMessageId;
        private Int32 mMemberId;
        private string mMessage;
        private DateTime mDatePosted;

        private string mUsername;

        public int MessageId
        {
            get { return mMessageId; }
            set { mMessageId = value; }
        }

        public int MemberId
        {
            get { return mMemberId; }
            set { mMemberId = value; }
        }

        public string Message
        {
            get { return mMessage; }
            set { mMessage = value; }
        }

        public DateTime DatePosted
        { 
            get { return mDatePosted; }
            set { mDatePosted = value; }
        }

        public string Username
        {
            get { return mUsername; }
            set { mUsername = value; }
        }

        public bool Find(int MessageId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MessageId", MessageId);
            DB.Execute("sproc_tblMessage_FilterByMessageId");

            if (DB.Count == 1)
            {
                mMessageId = Convert.ToInt32(DB.DataTable.Rows[0]["MessageId"]);
                mMemberId = Convert.ToInt32(DB.DataTable.Rows[0]["MemberId"]);
                mMessage = Convert.ToString(DB.DataTable.Rows[0]["Message"]);
                mDatePosted = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePosted"]);
                mUsername = GetUsernameFromMemberId(mMemberId);
                
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetUsernameFromMemberId(int memberId)
        {
            clsMember member = new clsMember();
            member.Find(memberId);
            return member.Username;
        }

        public string Valid(string message, string datePosted)
        {
            String Error = "";
            DateTime DateTemp;

            if (message.Length < 5)
            {
                Error = Error + "You must enter at least 5 characters.<br /> ";
            }

            if (message.Length > 150)
            {
                Error = Error + "The maximum length is 150 characters.<br /> ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(datePosted);

                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past.<br /> ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future.<br /> ";
                }
            }
            catch
            {
                Error = Error + "The date must be a valid date.<br /> ";
            }
            return Error;
        }

    }
}
