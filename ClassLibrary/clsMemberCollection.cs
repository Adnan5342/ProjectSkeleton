using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsMemberCollection
    {
        List<clsMember> mMemberList = new List<clsMember>();
        clsMember mThisMember = new clsMember();

        public clsMemberCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblRegistration_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mMemberList = new List<clsMember>();

            while (Index < RecordCount)
            {
                clsMember AMember = new clsMember();

                AMember.MemberId = Convert.ToInt32(DB.DataTable.Rows[Index]["MemberId"]);
                AMember.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                AMember.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AMember.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);

                mMemberList.Add(AMember);
                Index++;
            }
        }

        public List<clsMember> MemberList
        {
            get { return mMemberList; }
            set { mMemberList = value; }
        }

        public int Count
        {
            get { return mMemberList.Count; }
            set { /*do later*/ }
        }

        public clsMember ThisMember
        {
            get { return mThisMember; }
            set { mThisMember = value; }
        }

        public void Delete(int MemberId)
        {
            clsMovieReviewCollection MovieReviews = new clsMovieReviewCollection();
            MovieReviews.DeleteMovieReviewsByMemberId(MemberId);

            clsShowReviewCollection ShowReviews = new clsShowReviewCollection();
            ShowReviews.DeleteShowReviewsByMemberId(MemberId);

            clsMessageCollection Messages = new clsMessageCollection();
            Messages.DeleteMessagesByMemberId(MemberId);

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MemberId", MemberId);
            DB.Execute("sproc_tblRegistration_Delete");
        }

    }
}
