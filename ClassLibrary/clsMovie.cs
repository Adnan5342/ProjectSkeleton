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
            String Error = "";
            TimeSpan TempRuntime;
            DateTime TempReleaseDate;
            double TempRating;
            
            if (title.Length == 0)
            {
                Error = Error + "The 'title' must not be blank. <br /> ";
            }

            if (title.Length < 1)
            {
                Error = Error + "The 'title' must have at least 1 character. <br /> ";
            }

            if (title.Length > 100)
            {
                Error = Error + "The 'title' must be under 100 characters. <br /> ";
            }

            try
            {
                TempRuntime = TimeSpan.Parse(runtime);

                if (TempRuntime < TimeSpan.Parse("0:05"))
                {
                    Error = Error + "The 'runtime' must be more than 5 minutes. <br /> ";
                }

                if (TempRuntime > TimeSpan.Parse("10:00"))
                {
                    Error = Error + "The 'runtime' must not exceed 10 hours. <br /> ";
                }
            } 
            catch
            {
                Error = Error + "The 'runtime' must be a valid timespan. <br /> ";
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

            if (description.Length > 1000)
            {
                Error = Error + "The 'description' must not exceed 1000 characters. <br /> ";
            }

            if (genre.Length < 3)
            {
                Error = Error + "The 'genre' section must have at least 3 characters. <br /> ";
            }

            if (genre.Length > 50)
            {
                Error = Error + "The 'genre' section must not exceed 50 characters. <br /> ";
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

            if (directors.Length == 0)
            {
                Error = Error + "The 'directors' section must not be blank. <br /> ";
            }

            if (directors.Length > 200)
            {
                Error = Error + "The 'directors' section must not exceed 200 characters. <br /> ";
            }

            if (writers.Length == 0)
            {
                Error = Error + "The 'writers' section must not be blank. <br /> ";
            }

            if (writers.Length > 200)
            {
                Error = Error + "The 'writers' section must not be blank. <br /> ";
            }

            if (starActors.Length > 200)
            {
                Error = Error + "The 'star actors' section must not exceed 200 characters. <br /> ";
            }

            return Error;
        }
    }
}