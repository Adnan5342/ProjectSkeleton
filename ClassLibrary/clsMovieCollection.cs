using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibrary
{
    public class clsMovieCollection
    {
        //private data member
        List<clsMovie> mMovieList = new List<clsMovie>();
        clsMovie mThisMovie = new clsMovie();

        public clsMovieCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblMovie_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsMovie AMovie = new clsMovie();

                AMovie.MovieId = Convert.ToInt32(DB.DataTable.Rows[Index]["MovieId"]);
                AMovie.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AMovie.Runtime = TimeSpan.Parse(Convert.ToString(DB.DataTable.Rows[Index]["Runtime"]));
                AMovie.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                AMovie.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AMovie.Genre = Convert.ToString(DB.DataTable.Rows[Index]["Genre"]);
                AMovie.Rating = Convert.ToDouble(DB.DataTable.Rows[Index]["Rating"]);
                AMovie.Directors = Convert.ToString(DB.DataTable.Rows[Index]["Directors"]);
                AMovie.Writers = Convert.ToString(DB.DataTable.Rows[Index]["Writers"]);
                AMovie.StarActors = Convert.ToString(DB.DataTable.Rows[Index]["StarActors"]);
                AMovie.CoverImage = Convert.ToString(DB.DataTable.Rows[Index]["CoverImage"]);

                mMovieList.Add(AMovie);
                Index++;
            }
        }

        public List<clsMovie> MovieList
        {
            get
            {
                return mMovieList;
            }
            set
            {
                mMovieList = value;
            }
        }

        public int Count
        {
            get
            {
                return mMovieList.Count;
            }
            set
            {
                //do later
            }
        }

        public clsMovie ThisMovie
        {
            get
            {
                return mThisMovie;
            }
            set
            {
                mThisMovie = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Title", mThisMovie.Title);
            DB.AddParameter("@Runtime", mThisMovie.Runtime);
            DB.AddParameter("@ReleaseDate", mThisMovie.ReleaseDate);
            DB.AddParameter("@Description", mThisMovie.Description);
            DB.AddParameter("@Genre", mThisMovie.Genre);
            DB.AddParameter("@Rating", mThisMovie.Rating);
            DB.AddParameter("@Directors", mThisMovie.Directors);
            DB.AddParameter("@Writers", mThisMovie.Writers);
            DB.AddParameter("@StarActors", mThisMovie.StarActors);
            DB.AddParameter("@CoverImage", mThisMovie.CoverImage);

            return DB.Execute("sproc_tblMovie_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@MovieId", mThisMovie.MovieId);
            DB.AddParameter("@Title", mThisMovie.Title);
            DB.AddParameter("@Runtime", mThisMovie.Runtime);
            DB.AddParameter("@ReleaseDate", mThisMovie.ReleaseDate);
            DB.AddParameter("@Description", mThisMovie.Description);
            DB.AddParameter("@Genre", mThisMovie.Genre);
            DB.AddParameter("@Rating", mThisMovie.Rating);
            DB.AddParameter("@Directors", mThisMovie.Directors);
            DB.AddParameter("@Writers", mThisMovie.Writers);
            DB.AddParameter("@StarActors", mThisMovie.StarActors);
            DB.AddParameter("@CoverImage", mThisMovie.CoverImage);

            DB.Execute("sproc_tblMovie_Update");
        }
    }
}