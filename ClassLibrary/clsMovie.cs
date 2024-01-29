using System;

namespace ClassLibrary
{
    public class clsMovie
    {
        private Int32 mMovieId;
        private string mTitle;
        private TimeSpan mRuntime;
        private DateTime mReleaseDate;
        private string mDescription;
        private string mGenre;
        private double mRating;
        private string mDirectors;
        private string mWriters;
        private string mStarActors;
        private string mCoverImage;

        public Int32 MovieId 
        {
            get { return mMovieId; }
            set { mMovieId = value; }
        }

        public string Title 
        {
            get { return mTitle; }
            set { mTitle = value; }
        }

        public TimeSpan Runtime 
        {
            get { return mRuntime; }
            set { mRuntime = value; }
        }

        public DateTime ReleaseDate 
        {
            get { return mReleaseDate; }
            set { mReleaseDate = value; }
        }

        public string Description 
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        public string Genre 
        {
            get { return mGenre; }
            set { mGenre = value; }
        }

        public double Rating 
        {
            get { return mRating; }
            set { mRating = value; }
        }

        public string Directors
        {
            get { return mDirectors; }
            set { mDirectors = value; }
        }

        public string Writers
        {
            get { return mWriters; }
            set { mWriters = value; }
        }

        public string StarActors
        {
            get { return mStarActors; }
            set { mStarActors = value; }
        }

        public string CoverImage
        {
            get { return mCoverImage; }
            set { mCoverImage = value; }
        }

        public bool Find(int MovieId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MovieId", MovieId);
            DB.Execute("sproc_tblMovie_FilterByMovieId");
            //should be either one or zero
            if (DB.Count == 1)
            {
                //copy data from database to private data members
                mMovieId = Convert.ToInt32(DB.DataTable.Rows[0]["MovieId"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mRuntime = TimeSpan.Parse(Convert.ToString(DB.DataTable.Rows[0]["Runtime"]));
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mGenre = Convert.ToString(DB.DataTable.Rows[0]["Genre"]);
                mRating = Convert.ToDouble(DB.DataTable.Rows[0]["Rating"]);
                mDirectors = Convert.ToString(DB.DataTable.Rows[0]["Directors"]);
                mWriters = Convert.ToString(DB.DataTable.Rows[0]["Writers"]);
                mStarActors = Convert.ToString(DB.DataTable.Rows[0]["StarActors"]);
                mCoverImage = Convert.ToString(DB.DataTable.Rows[0]["CoverImage"]);

                return true;
            }     
            else
            {
                return false;
            }
        }

        public string Valid(string title, string runtime, string releaseDate, string description, string genre, 
            string rating, string directors, string writers, string starActors)
        {
           return "";
        }
    }
}