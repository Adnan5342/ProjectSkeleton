using System;
using System.CodeDom;
using System.IO;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsMovieReviewCollection
    {
        List<clsMovieReview> mMovieReviewList = new List<clsMovieReview>();
        clsMovieReview mThisMovieReview = new clsMovieReview();

        public List<clsMovieReview> MovieReviewList
        {
            get { return mMovieReviewList; }
            set { mMovieReviewList = value; }
        }


        public int Count
        {
            get { return mMovieReviewList.Count; }
            set { /*for later*/ }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@MovieId", mThisMovieReview.MovieId);
            DB.AddParameter("@memberId", mThisMovieReview.MemberId);
            DB.AddParameter("@Rating", mThisMovieReview.Rating);
            DB.AddParameter("@Comment", mThisMovieReview.Comment);
            DB.AddParameter("@DatePosted", mThisMovieReview.DatePosted);

            return DB.Execute("sproc_tblMovieReview_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@MovieReviewId", mThisMovieReview.MovieReviewId);
            DB.AddParameter("@MovieId", mThisMovieReview.MovieId);
            DB.AddParameter("@memberId", mThisMovieReview.MemberId);
            DB.AddParameter("@Rating", mThisMovieReview.Rating);
            DB.AddParameter("@Comment", mThisMovieReview.Comment);
            DB.AddParameter("@DatePosted", mThisMovieReview.DatePosted);

            DB.Execute("sproc_tblMovieReview_Update");
        }

        public void Delete(int MovieReviewId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MovieReviewId", MovieReviewId);
            DB.Execute("sproc_tblMovieReview_Delete");
        }

        public clsMovieReview ThisMovieReview
        {
            get { return mThisMovieReview; }
            set { mThisMovieReview = value; }
        }


        public clsMovieReviewCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblMovieReview_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mMovieReviewList = new List<clsMovieReview>();

            while (Index < RecordCount)
            {
                clsMovieReview AMovieReview = new clsMovieReview();

                AMovieReview.MovieReviewId = Convert.ToInt32(DB.DataTable.Rows[Index]["MovieReviewId"]);
                AMovieReview.MovieId = Convert.ToInt32(DB.DataTable.Rows[Index]["MovieId"]);
                AMovieReview.MemberId = Convert.ToInt32(DB.DataTable.Rows[Index]["memberId"]);
                AMovieReview.Rating = Convert.ToDouble(DB.DataTable.Rows[Index]["Rating"]);
                AMovieReview.Comment = Convert.ToString(DB.DataTable.Rows[Index]["Comment"]);
                AMovieReview.DatePosted = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePosted"]);

                mMovieReviewList.Add(AMovieReview);
                Index++;
            }
        }

        public void ReportByMovieId(Int32 MovieId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MovieId", MovieId);
            DB.Execute("sproc_tblMovieReview_FilterByMovieId");
            PopulateArray(DB);
        }

        public void DeleteReviewsByMovieId(int MovieId)
        {
            List<clsMovieReview> reviewsToDelete = new List<clsMovieReview>();

            foreach (clsMovieReview review in MovieReviewList)
            {
                if (review.MovieId == MovieId)
                {
                    reviewsToDelete.Add(review);
                }
            }
            foreach (clsMovieReview review in reviewsToDelete)
            {
                Delete(review.MovieReviewId);
            }
        }

        public void DeleteMovieReviewsByMemberId(int MemberId)
        {
            List<clsMovieReview> reviewsToDelete = new List<clsMovieReview>();

            foreach (clsMovieReview review in MovieReviewList)
            {
                if (review.MemberId == MemberId)
                {
                    reviewsToDelete.Add(review);
                }
            }
            foreach (clsMovieReview review in reviewsToDelete)
            {
                Delete(review.MovieReviewId);
            }
        }

    }
}