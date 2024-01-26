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

        public bool Find(int movieId)
        {
            mMovieId = 21;
            mTitle = "The Lost World";
            mRuntime = new TimeSpan(1, 30, 0);
            mReleaseDate = new DateTime(2002, 1, 7);
            mDescription = "A very exciting movie!";
            mGenre = "Action";
            mRating = 4.5;
            mDirectors = "John Smith";
            mWriters = "Smith John";
            mStarActors = "Tom Holland";
            mCoverImage = "MovieCoverImages/UnchartedMoviePoster.jpg";

            return true;
        }
    }
}