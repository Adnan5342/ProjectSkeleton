using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsShowReview
    {
        private Int32 mShowReviewId;
        private Int32 mShowId;
        private Int32 mMemberId;
        private DateTime mDatePosted;
        private double mRating;
        private string mComment;

        private string mUsername;
        private string mShowTitle;

        public int ShowReviewId
        {
            get { return mShowReviewId; }
            set { mShowReviewId = value; }
        }

        public int ShowId
        {
            get { return mShowId; }
            set { mShowId = value; }
        }

        public int MemberId
        {
            get { return mMemberId; }
            set { mMemberId = value; }
        }

        public DateTime DatePosted
        {
            get { return mDatePosted; }
            set { mDatePosted = value; }
        }

        public double Rating
        {
            get { return mRating; }
            set { mRating = value; }
        }

        public string Comment
        {
            get { return mComment; }
            set { mComment = value; }
        }

        public string Username
        {
            get { return mUsername; }
            set { mUsername = value; }
        }

        public string ShowTitle
        {
            get { return mShowTitle; }
            set { mShowTitle = value; }
        }

        public bool Find(int ShowReviewId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ShowReviewId", ShowReviewId);
            DB.Execute("sproc_tblShowReview_FilterByShowReviewId");

            if (DB.Count == 1)
            {
                mShowReviewId = Convert.ToInt32(DB.DataTable.Rows[0]["ShowReviewId"]);
                mShowId = Convert.ToInt32(DB.DataTable.Rows[0]["ShowId"]);
                mMemberId = Convert.ToInt32(DB.DataTable.Rows[0]["memberId"]);
                mDatePosted = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePosted"]);
                mRating = Convert.ToDouble(DB.DataTable.Rows[0]["Rating"]);
                mComment = Convert.ToString(DB.DataTable.Rows[0]["Comment"]);
                mUsername = GetUsernameFromMemberId(mMemberId);
                mShowTitle = GetShowTitleFromShowId(mShowId);

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

        private string GetShowTitleFromShowId(int showId)
        {
            clsShow Show = new clsShow();
            Show.Find(showId);
            return Show.Title;
        }

        public string Valid(string rating, string comment, string datePosted)
        {
            String Error = "";
            DateTime DateTemp;
            double TempRating;

            try
            {
                TempRating = Convert.ToDouble(rating);

                if (TempRating == 0)
                {
                    Error = Error + "You must enter a rating from 1 to 5.";
                }
                if (TempRating < 0)
                {
                    Error = Error + "The rating must not be negative. ";
                }
                if (TempRating > 5)
                {
                    Error = Error + "The rating must not exceed 5. ";
                }
            }
            catch
            {
                Error = Error + "The rating must be a valid number. ";
            }

            if (comment.Length == 0)
            {
                Error = Error + "You must not leave the comment box empty.";
            }

            if (comment.Length > 500)
            {
                Error = Error + "Comments must not exceed 500 characters. ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(datePosted);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past. ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future. ";
                }
            }
            catch
            {
                Error = Error + "The date must be a valid date. ";
            }
            return Error;

        }
    }
}
