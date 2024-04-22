using System;
using System.CodeDom;
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
            DB.AddParameter("@MemberId", mThisMovieReview.MemberId);
            DB.AddParameter("@Rating", mThisMovieReview.Rating);
            DB.AddParameter("@Comment", mThisMovieReview.Comment);
            DB.AddParameter("@DatePosted", mThisMovieReview.DatePosted);

            return DB.Execute("sproc_tblMovieReview_Insert");
        }

        public clsMovieReview ThisMovieReview
        {
            get { return mThisMovieReview; }
            set { mThisMovieReview = value; }
        }

        public clsMovieReviewCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblMovieReview_SelectAll");
            RecordCount = DB.Count;

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

    }
}