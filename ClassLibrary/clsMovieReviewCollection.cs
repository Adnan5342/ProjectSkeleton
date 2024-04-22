using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsMovieReviewCollection
    {
        List<clsMovieReview> mMovieReviewList = new List<clsMovieReview>();

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

        public clsMovieReview ThisMovieReview { get; set; }

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