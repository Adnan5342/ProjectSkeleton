using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsMessageCollection
    {
        List<clsMessage> mMessageList = new List<clsMessage>();
        clsMessage mThisMessage = new clsMessage();

        public List<clsMessage> MessageList
        {
            get { return mMessageList; }
            set { mMessageList = value; }
        }

        public int Count
        {
            get { return mMessageList.Count; }
            set { /*for later*/ }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@memberId", mThisMessage.MemberId);
            DB.AddParameter("@Message", mThisMessage.Message);
            DB.AddParameter("@DatePosted", mThisMessage.DatePosted);

            return DB.Execute("sproc_tblMessage_Insert");
        }

        public void Delete(int MessageId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MessageId", MessageId);
            DB.Execute("sproc_tblMessage_Delete");
        }

        public clsMessage ThisMessage
        {
            get { return mThisMessage; }
            set { mThisMessage = value; }
        }

        public clsMessageCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblMessage_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mMessageList = new List<clsMessage>();

            while (Index < RecordCount)
            {
                clsMessage AMessage = new clsMessage();

                AMessage.MessageId = Convert.ToInt32(DB.DataTable.Rows[Index]["MessageId"]);
                AMessage.MemberId = Convert.ToInt32(DB.DataTable.Rows[Index]["MemberId"]);
                AMessage.Message = Convert.ToString(DB.DataTable.Rows[Index]["Message"]);
                AMessage.DatePosted = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePosted"]);
            
                mMessageList.Add(AMessage);
                Index++;
            }
        }

        public void ReportByMessageId(Int32 MessageId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MessageId", MessageId);
            DB.Execute("sproc_tblMessage_FilterByMessageId");
            PopulateArray(DB);
        }

        public void DeleteMessagesByMemberId(int MemberId)
        {
            List<clsMessage> messagesToDelete = new List<clsMessage>();

            foreach (clsMessage message in MessageList)
            {
                if (message.MemberId == MemberId)
                {
                    messagesToDelete.Add(message);
                }
            }
            foreach (clsMessage message in messagesToDelete)
            {
                Delete(message.MessageId);
            }
        }

        public void ReportByMostRecent10()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblMessage_FilterByMostRecent10");
            PopulateArray(DB);
        }
    }
}
