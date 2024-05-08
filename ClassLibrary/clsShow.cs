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
         
        public Int32 ShowId
        {
            get { return mShowId; }
            set { mShowId = value; }
        }

        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }

        public Int32 Seasons
        {
            get { return mSeasons; }
            set { mSeasons = value; }
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

        public string Creators
        {
            get { return mCreators; }
            set { mCreators = value; }
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

        public bool Find(int ShowId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ShowId", ShowId);
            DB.Execute("sproc_tblShow_FilterByShowId");
            if (DB.Count == 1)
            {
                mShowId = Convert.ToInt32(DB.DataTable.Rows[0]["ShowId"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mSeasons = Convert.ToInt32(DB.DataTable.Rows[0]["Seasons"]);
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mGenre = Convert.ToString(DB.DataTable.Rows[0]["Genre"]);
                mRating = Convert.ToDouble(DB.DataTable.Rows[0]["Rating"]);
                mCreators = Convert.ToString(DB.DataTable.Rows[0]["Creators"]);
                mStarActors = Convert.ToString(DB.DataTable.Rows[0]["StarActors"]);
                mCoverImage = Convert.ToString(DB.DataTable.Rows[0]["CoverImage"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string title, string description, string genre, string creators, 
            string starActors, string coverImage, string releaseDate, string rating, string seasons)
        {
            String Error = "";
            DateTime TempReleaseDate;
            double TempRating;
            Int32 TempSeasons;

            if (title.Length == 0)
            {
                Error = Error + "The title may not be blank. <br /> ";
            }
            if (title.Length > 100)
            {
                Error = Error + "The title must not exceed 100 characters. <br /> ";
            }

            if (description.Length > 1000)
            {
                Error = Error + "The description must not exceed 1000 characters. <br /> ";
            }

            if (genre.Length < 3)
            {
                Error = Error + "The genre must be at least 3 characters. <br /> ";
            }
            if (genre.Length > 50)
            {
                Error = Error + "The genre must not exceed 50 characters. <br /> ";
            }

            if (creators.Length > 200)
            {
                Error = Error + "'Creators' must not exceed 200 characters. <br /> ";
            }

            if (starActors.Length > 200)
            {
                Error = Error + "'Star Actors must not exceed 200 characters. <br /> ";
            }

            if (coverImage.Length > 100)
            {
                Error = Error + "The cover image must not exceed 100 characters. <br /> ";
            }

            try
            {
                TempReleaseDate = Convert.ToDateTime(releaseDate);

                if (TempReleaseDate < Convert.ToDateTime("01/01/1900"))
                {
                    Error = Error + "The 'release date' must be no earlier than 01/01/1900. <br /> ";
                }
                if (TempReleaseDate > DateTime.Now.Date.AddDays(60))
                {
                    Error = Error + "The 'release date' must be no later than 60 days in the future. <br /> ";
                }
            }
            catch
            {
                Error = Error + "The 'release date' must be a valid date. <br /> ";
            }

            try
            {
                TempRating = Convert.ToDouble(rating);

                if (TempRating < 0)
                {
                    Error = Error + "The 'rating' must not be a negative number. <br /> ";
                }

                if (TempRating == 0)
                {
                    Error = Error + "You must enter a rating from 1 to 5. <br /> ";
                }

                if (TempRating > 5)
                {
                    Error = Error + "The 'rating' cannot be above 5. <br /> ";
                }
            }
            catch
            {
                Error = Error + "The 'rating' must be a valid number from 0 to 5. <br /> ";
            }

            try
            {
                TempSeasons = Convert.ToInt32(seasons);

                if (TempSeasons < 0)
                {
                    Error = Error + "The number of seasons cannot be negative. <br /> ";
                }
            }
            catch
            {
                Error = Error + "'Seasons' must a valid number. <br /> ";
            }
            return Error;
        }
    }
}