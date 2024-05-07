using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsShowReviewCollection
    {
        List<clsShowReview> mShowReviewList = new List<clsShowReview>();
        clsShowReview mThisShowReview = new clsShowReview();

        public List<clsShowReview> ShowReviewList
        {
            get { return mShowReviewList; }
            set { mShowReviewList = value; }
        }

        public int Count
        {
            get { return mShowReviewList.Count; }
            set { /*for later*/ }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ShowId", mThisShowReview.ShowId);
            DB.AddParameter("@memberId", mThisShowReview.MemberId);
            DB.AddParameter("@Rating", mThisShowReview.Rating);
            DB.AddParameter("@Comment", mThisShowReview.Comment);
            DB.AddParameter("@DatePosted", mThisShowReview.DatePosted);

            return DB.Execute("sproc_tblShowReview_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ShowReviewId", mThisShowReview.ShowReviewId);
            DB.AddParameter("@MovieId", mThisShowReview.ShowId);
            DB.AddParameter("@memberId", mThisShowReview.MemberId);
            DB.AddParameter("@Rating", mThisShowReview.Rating);
            DB.AddParameter("@Comment", mThisShowReview.Comment);
            DB.AddParameter("@DatePosted", mThisShowReview.DatePosted);

            DB.Execute("sproc_tblShowReview_Update");
        }

        public void Delete(int ShowReviewId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ShowReviewId", ShowReviewId);
            DB.Execute("sproc_tblShowReview_Delete");
        }

        public clsShowReview ThisShowReview
        {
            get { return mThisShowReview; }
            set { mThisShowReview = value; }
        }

        public clsShowReviewCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblShowReview_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mShowReviewList = new List<clsShowReview>();

            while (Index < RecordCount)
            {
                clsShowReview AShowReview = new clsShowReview();

                AShowReview.ShowReviewId = Convert.ToInt32(DB.DataTable.Rows[Index]["ShowReviewId"]);
                AShowReview.ShowId = Convert.ToInt32(DB.DataTable.Rows[Index]["ShowId"]);
                AShowReview.MemberId = Convert.ToInt32(DB.DataTable.Rows[Index]["memberId"]);
                AShowReview.Rating = Convert.ToDouble(DB.DataTable.Rows[Index]["Rating"]);
                AShowReview.Comment = Convert.ToString(DB.DataTable.Rows[Index]["Comment"]);
                AShowReview.DatePosted = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePosted"]);
                AShowReview.Username = GetUsernameFromMemberId(AShowReview.MemberId);
                AShowReview.ShowTitle = GetShowTitleFromShowId(AShowReview.ShowId);
                
                mShowReviewList.Add(AShowReview);
                Index++;
            }
        }

        private string GetUsernameFromMemberId(int memberId)
        {
            clsMember member = new clsMember();
            member.Find(memberId);
            return member.Username;
        }

        private string GetShowTitleFromShowId(int showId)
        {
            clsShow Show = new clsShow();
            Show.Find(showId);
            return Show.Title;
        }

        public void ReportByShowId(Int32 ShowId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ShowId", ShowId);
            DB.Execute("sproc_tblShowReview_FilterByShowId");
            PopulateArray(DB);
        }

        public void DeleteReviewsByShowId(int ShowId)
        {
            List<clsShowReview> reviewsToDelete = new List<clsShowReview>();

            foreach (clsShowReview review in ShowReviewList)
            {
                if (review.ShowId == ShowId)
                {
                    reviewsToDelete.Add(review);
                }
            }
            foreach (clsShowReview review in reviewsToDelete)
            {
                Delete(review.ShowReviewId);
            }
        }

        public void DeleteShowReviewsByMemberId(int MemberId)
        {
            List<clsShowReview> reviewsToDelete = new List<clsShowReview>();

            foreach (clsShowReview review in ShowReviewList)
            {
                if (review.MemberId == MemberId)
                {
                    reviewsToDelete.Add(review);
                }
            }
            foreach (clsShowReview review in reviewsToDelete)
            {
                Delete(review.ShowReviewId);
            }
        }
    }
}
