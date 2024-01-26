using System;

namespace ClassLibrary
{
    public class clsMovie
    {
        private Int32 mMovieId;
        private string mTitle;
        private TimeSpan mRuntime;
        private DateTime mReleaseDate;

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

        public string Description { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string Directors { get; set; }
        public string Writers { get; set; }
        public string StarActors { get; set; }
        public string CoverImage { get; set; }

        public bool Find(int movieId)
        {
            mMovieId = 21;
            
            return true;
        }
    }
}