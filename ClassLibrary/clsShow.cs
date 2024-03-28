using System;

namespace ClassLibrary
{
    public class clsShow
    {
        private Int32 mShowId;
        private string mTitle;
        private Int32 mSeasons;
        private DateTime mReleaseDate;
        private string mDescription;
        private string mGenre;
        private double mRating;
        private string mCreators;
        private string mStarActors;
        private string mCoverImage;

        public int ShowId
        {
            get
            {
                return mShowId;
            }
            set
            {
                mShowId = value;
            }
        }

        public string Title
        {
            get
            {
                return mTitle;
            }
            set
            {
                mTitle = value;
            }
        }

        public int Seasons
        {
            get
            {
                return mSeasons;
            }
            set
            {
                mSeasons = value;
            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                return mReleaseDate;
            }
            set
            {
                mReleaseDate = value;
            }
        }

        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }

        public string Genre
        {
            get
            {
                return mGenre;
            }
            set
            {
                mGenre = value;
            }
        }

        public double Rating
        {
            get
            {
                return mRating;
            }
            set
            {
                mRating = value;
            }
        }
        public string Creators
        {
            get 
            {
                return mCreators;
            }
            set
            {
                mCreators = value;
            }
        }

        public string StarActors
        {
            get
            {
                return mStarActors;
            }
            set
            {
                mStarActors = value;
            }
        }

        public string CoverImage
        {
            get
            {
                return mCoverImage;
            }
            set
            {
                mCoverImage = value;
            }
        }

        public bool Find(int ShowId)
        {
            mShowId = 1;
            mTitle = "Title";
            mSeasons = 3;
            mReleaseDate = Convert.ToDateTime("07/01/2002");
            mDescription = "A lovely description";
            mGenre = "Action";
            mRating = 4.5;
            mCreators = "A name";
            mStarActors = "Another name";
            mCoverImage = string.Empty;

            return true;
        }
    }
}